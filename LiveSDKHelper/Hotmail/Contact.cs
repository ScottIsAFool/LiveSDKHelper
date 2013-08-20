using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Contact
    {
		public Contact() { }

		public static Contact FromJson(string json)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Contact));
			using(var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
				return ser.ReadObject(ms) as Contact;
		}

        [DataMember(Name = "id")]
        public string Id { get; internal set; }

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
        public string UserId { get; internal set; }

        [DataMember(Name = "email_hashes")]
        public List<string> EmailHashes { get; set; }

        [DataMember(Name = "udpated_time")]
        public DateTime UpdatedTime { get; set; }
    }
}
