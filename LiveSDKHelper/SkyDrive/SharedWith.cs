using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class SharedWith
    {
        [DataMember(Name = "access")]
        public string Access { get; set; }
    }
}