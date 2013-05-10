using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}