using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public enum ImageType
    {
        [DataMember(Name = "normal")]
        Normal,
        [DataMember(Name = "album")]
        Album,
        [DataMember(Name = "thumbnail")]
        Thumbnail,
        [DataMember(Name = "full")]
        Full
    }
}