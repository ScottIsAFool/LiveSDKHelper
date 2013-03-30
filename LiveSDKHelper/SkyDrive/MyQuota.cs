using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class MyQuota
    {
        [DataMember(Name = "quota")]
        public long Quota { get; set; }
        [DataMember(Name = "available")]
        public long Available { get; set; }
    }
}