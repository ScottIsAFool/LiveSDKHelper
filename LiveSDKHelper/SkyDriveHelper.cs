using System;
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
        /// Gets the shared read link.
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetSharedReadLink(string itemId)
        {
            if (string.IsNullOrEmpty(itemId))
            {
                throw new ArgumentNullException(itemId);
            }

            return string.Format("{0}/{1}", itemId, SkyDriveConstants.GetSharedReadLink);
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
    }
}
