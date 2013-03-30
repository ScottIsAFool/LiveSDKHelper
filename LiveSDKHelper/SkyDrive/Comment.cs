using System;
using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class Comment
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "from")]
        public User From { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }
        [DataMember(Name = "created_time")]
        public DateTime CreatedTime { get; set; }
    }
}
