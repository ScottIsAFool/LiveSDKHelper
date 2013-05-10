using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Contact
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "gender")]
        public object Gender { get; set; }

        [DataMember(Name = "is_friend")]
        public bool IsFriend { get; set; }

        [DataMember(Name = "is_favorite")]
        public bool IsFavorite { get; set; }

        [DataMember(Name = "user_id")]
        public string UserId { get; set; }

        [DataMember(Name = "email_hashes")]
        public List<string> EmailHashes { get; set; }

        [DataMember(Name = "udpated_time")]
        public DateTime UpdatedTime { get; set; }
    }
}
