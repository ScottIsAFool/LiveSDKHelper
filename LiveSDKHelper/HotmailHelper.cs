using System;
using LiveSDKHelper.Hotmail;

namespace LiveSDKHelper
{
    public static class HotmailHelper
    {
        private const string HotmailBaseUrl = "https://apis.live.net/v5.0/";

        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetContacts(string userId, int? limit = null, int? offset = null)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            var query = GetQuery(limit, offset);

            return string.Format("{0}/{1}{2}", userId, HotmailConstants.GetContacts, query);
        }

        /// <summary>
        /// Gets the friends.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetFriends(string userId, int? limit = null, int? offset = null)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            var query = GetQuery(limit, offset);

            return string.Format("{0}/{1}{2}", userId, HotmailConstants.GetFriends, query);
        }

        /// <summary>
        /// Gets the calendars.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetCalendars(string userId, int? limit = null, int? offset = null)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(userId);
            }

            var query = GetQuery(limit, offset);

            return string.Format("{0}/{1}{2}", userId, HotmailConstants.GetCalendars, query);
        }

        /// <summary>
        /// Gets the events. If a start date is specified and no end date is specified, then the default end time is 30 minutes after the start time. If no start or end time specified,
        /// it will be events between the current time and 30 days in the future that will be returned. 
        /// </summary>
        /// <param name="id">The id, this can be a user ID or a Calendar ID</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetEvents(string id, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(id);
            }

            var query = GetQuery(startDate: startDate, endDate: endDate);

            return string.Format("{0}/{1}{2}", id, HotmailConstants.GetEvents, query);
        }

        #region Private methods
        private static string GetQuery(int? limit = null, int? offset= null, DateTime? startDate = null, DateTime? endDate = null)
        {
            const string dateFormat = "yyyy-mm-ddThh:mm:ssZ";
            var uri = new UriBuilder(HotmailBaseUrl);

            if (limit.HasValue)
            {
                uri.SetQueryParam(LiveSdkConstants.Limit, limit.Value.ToString());
            }

            if (offset.HasValue)
            {
                uri.SetQueryParam(LiveSdkConstants.Offset, offset.Value.ToString());
            }

            if (startDate.HasValue)
            {
                uri.SetQueryParam(HotmailConstants.StartDate, startDate.Value.ToString(dateFormat));
            }

            if (endDate.HasValue)
            {
                uri.SetQueryParam(HotmailConstants.EndDate, endDate.Value.ToString(dateFormat));
            }

            return uri.Query;
        }
        #endregion
    }
}
