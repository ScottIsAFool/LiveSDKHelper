using System;
using System.Runtime.Serialization;

namespace LiveSDKHelper
{
    [DataContract]
    public class MeDetails
    {
        [DataMember(Name= "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "gender")]
        public object Gender { get; set; }

        [DataMember(Name = "locale")]
        public string Locale { get; set; }

        [DataMember(Name = "updated_time")]
        public DateTime UpdatedTime { get; set; }

        public static string CameraRollFolder
        {
            get { return SkyDriveHelper.GetCameraRollFolder(LiveSdkConstants.MyDetails); }
        }

        public static string MyDocumentsFolder
        {
            get { return SkyDriveHelper.GetMyDocumentsFolder(LiveSdkConstants.MyDetails); }
        }

        public static string MyPhotosFolder
        {
            get { return SkyDriveHelper.GetMyPhotosFolder(LiveSdkConstants.MyDetails); }
        }

        public static string PublicDocumentsFolder
        {
            get { return SkyDriveHelper.GetPublicDocumentsFolder(LiveSdkConstants.MyDetails); }
        }

        public static string TopLevelSkyDriveFolder
        {
            get { return SkyDriveHelper.GetSkyDriveTopLevelFolder(LiveSdkConstants.MyDetails); }
        }

        public static string MyFiles
        {
            get { return SkyDriveHelper.GetFilesForFolder(LiveSdkConstants.MyDetails); }
        }

        public static string MyContacts
        {
            get { return HotmailHelper.GetContacts(LiveSdkConstants.MyDetails); }
        }

        public static string MyFriends
        {
            get { return HotmailHelper.GetFriends(LiveSdkConstants.MyDetails); }
        }

        public static string MyCalendars
        {
            get { return HotmailHelper.GetCalendars(LiveSdkConstants.MyDetails); }
        }

        public static string MyEvents
        {
            get { return HotmailHelper.GetEvents(LiveSdkConstants.MyDetails); }
        }
    }
}
