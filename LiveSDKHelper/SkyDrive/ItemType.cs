using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public enum ItemType
    {
        [DataMember(Name = "album")]
        Album,

        [DataMember(Name = "folder")]
        Folder,

        [DataMember(Name = "file")]
        File,

        [DataMember(Name= "photo")]
        Photo,

        [DataMember(Name = "notebook")]
        Notebook
    }
}