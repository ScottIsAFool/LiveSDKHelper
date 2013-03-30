using LiveSDKHelper.SkyDrive;

namespace LiveSDKHelper
{
    public static class SkyDriveHelper
    {
        private const string FolderFormat = "{0}/skydrive/{1}";

        public static string GetCameraRollFolder(string userId)
        {
            return string.Format(FolderFormat, userId, SkyDriveConstants.CameraRoll);
        }

        public static string GetMyDocumentsFolder(string userId)
        {
            return string.Format(FolderFormat, userId, SkyDriveConstants.MyDocuments);
        }

        public static string GetMyPhotosFolder(string userId)
        {
            return string.Format(FolderFormat, userId, SkyDriveConstants.MyPhotos);
        }

        public static string GetPublicDocumentsFolder(string userId)
        {
            return string.Format(FolderFormat, userId, SkyDriveConstants.PublicDocuments);
        }
    }
}
