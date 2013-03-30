using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiveSDKHelper.SkyDrive;

namespace LiveSDKHelper
{
    public static class SkyDriveHelper
    {
        private const string FolderFormat = "{0}/skydrive/{1}";
        private const string SkyDriveBaseUrl = "https://apis.live.net/v5.0/skydrive/";

        /// <summary>
        /// Gets the camera roll folder.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetCameraRollFolder(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            return string.Format(FolderFormat, userId, SkyDriveConstants.CameraRoll);
        }

        /// <summary>
        /// Gets my documents folder.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetMyDocumentsFolder(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            return string.Format(FolderFormat, userId, SkyDriveConstants.MyDocuments);
        }

        /// <summary>
        /// Gets my photos folder.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetMyPhotosFolder(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            return string.Format(FolderFormat, userId, SkyDriveConstants.MyPhotos);
        }

        /// <summary>
        /// Gets the public documents folder.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetPublicDocumentsFolder(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            return string.Format(FolderFormat, userId, SkyDriveConstants.PublicDocuments);
        }

        /// <summary>
        /// Gets the sky drive top level folder.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetSkyDriveTopLevelFolder(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            return string.Format(FolderFormat, userId, SkyDriveConstants.GetFiles);
        }

        /// <summary>
        /// Gets the shared read link.
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetSharedLink(string itemId)
        {
            if (string.IsNullOrEmpty(itemId))
            {
                throw new ArgumentNullException(itemId);
            }

            return string.Format("{0}/{1}", itemId, SkyDriveConstants.GetSharedReadLink);
        }

        /// <summary>
        /// Gets the files for folder.
        /// </summary>
        /// <param name="folderId">The folder id.</param>
        /// <param name="filters">The filters.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="sortBy">The sort by.</param>
        /// <param name="sortOrder">The sort order.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetFilesForFolder(string folderId, List<FolderFilter> filters = null, int? limit = null, int? offset = null, SortBy? sortBy = null, SortOrder? sortOrder = null)
        {
            if (string.IsNullOrEmpty(folderId))
            {
                throw new ArgumentNullException(folderId);
            }

            var query = GetQuery(filters, limit, offset, sortBy, sortOrder);
            
            return string.Format("{0}/{1}{2}", folderId, SkyDriveConstants.GetFiles, query);
        }

        /// <summary>
        /// Gets the file.
        /// </summary>
        /// <param name="fileId">The file id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetFile(string fileId)
        {
            if (string.IsNullOrEmpty(fileId))
            {
                throw new ArgumentNullException(fileId);
            }

            return string.Format("{0}/{1}", fileId, SkyDriveConstants.GetFileContent);
        }
        
        /// <summary>
        /// Gets the preview URL.
        /// </summary>
        /// <param name="previewType">Type of the preview.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string GetPreviewUrl(PreviewType previewType, string url)
        {
            const string previewUrl = SkyDriveBaseUrl + SkyDriveConstants.GetItemPreview + "?type={0}&url={1}";
            return string.Format(previewUrl, previewType.ToString().ToLower(), Uri.EscapeDataString(url));
        }

        /// <summary>
        /// Gets the item comments.
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetItemComments(string itemId)
        {
            if (string.IsNullOrEmpty(itemId))
            {
                throw new ArgumentNullException(itemId);
            }

            return string.Format("{0}/{1}", itemId, SkyDriveConstants.GetComments);
        }

        #region Private methods
        private static string ParseFilters(List<FolderFilter> filters, UriBuilder uri)
        {
            var filterString = new StringBuilder();

            if (filters != null && filters.Any())
            {
                foreach (var filter in filters)
                {
                    filterString.AppendFormat("{0},", filter.ToString().ToLower());
                }

                if (filterString.ToString().EndsWith(","))
                {
                    filterString.Remove(filterString.Length - 1, 1);
                }
                uri.SetQueryParam(SkyDriveConstants.Filters, filterString.ToString());
            }

            return filterString.ToString();
        }

        private static string GetQuery(List<FolderFilter> filters, int? limit, int? offset, SortBy? sortBy, SortOrder? sortOrder)
        {
            var uri = new UriBuilder(SkyDriveBaseUrl + SkyDriveConstants.GetFiles);

            ParseFilters(filters, uri);

            if (limit.HasValue)
            {
                uri.SetQueryParam(SkyDriveConstants.Limit, limit.Value.ToString());
            }

            if (offset.HasValue)
            {
                uri.SetQueryParam(SkyDriveConstants.Offset, offset.Value.ToString());
            }

            if (sortBy.HasValue)
            {
                uri.SetQueryParam(SkyDriveConstants.SortBy, sortBy.ToString().ToLower());
            }

            if (sortOrder.HasValue)
            {
                uri.SetQueryParam(SkyDriveConstants.SortOrder, sortBy.ToString().ToLower());
            }

            return uri.Query;
        }
        
        private static UriBuilder SetQueryParam(this UriBuilder uri, string key, string value)
        {
            var collection = uri.ParseQuery();

            // add (or replace existing) key-value pair
            collection[key] = value;

            var query = collection
                .ToConcatenatedString(pair =>
                                      pair.Key == null
                                          ? pair.Value
                                          : pair.Key + "=" + pair.Value, "&");

            uri.Query = query;

            return uri;
        }

        private static IEnumerable<KeyValuePair<string, string>> GetQueryParams(
            this UriBuilder uri)
        {
            return uri.ParseQuery();
        }

        private static Dictionary<string, string> ParseQuery(this UriBuilder uri)
        {
            var nameValueCollection = new Dictionary<string, string>();
            string[] items = uri.Query.Split('&');

            foreach (string item in items)
            {
                if (item.Contains("="))
                {
                    string[] nameValue = item.Split('=');
                    if (nameValue[0].Contains("?"))
                        nameValue[0] = nameValue[0].Replace("?", "");
                    nameValueCollection.Add(nameValue[0], (nameValue[1]));
                }
            }

            return nameValueCollection;
        }

        private static string ToConcatenatedString<T>(this IEnumerable<T> source,
        Func<T, string> stringSelector)
        {
            return source.ToConcatenatedString(stringSelector, String.Empty);
        }

        /// <summary>
        /// Creates a string from the sequence by concatenating the result
        /// of the specified string selector function for each element.
        /// </summary>
        ///<param name="separator">The string which separates each concatenated item.</param>
        private static string ToConcatenatedString<T>(this IEnumerable<T> source,
            Func<T, string> stringSelector,
            string separator)
        {
            var b = new StringBuilder();
            bool needsSeparator = false; // don't use for first item

            foreach (var item in source)
            {
                if (needsSeparator)
                    b.Append(separator);

                b.Append(stringSelector(item));
                needsSeparator = true;
            }

            return b.ToString();
        }

        #endregion
    }
}
