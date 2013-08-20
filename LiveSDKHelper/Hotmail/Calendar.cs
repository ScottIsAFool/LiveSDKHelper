using System.Runtime.Serialization;
using LiveSDKHelper.SkyDrive;
using System.Runtime.Serialization.Json;
using System.IO;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Calendar
    {
		public Calendar() { }

		public static Calendar FromJson(string json)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Calendar));
			using(var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
				return ser.ReadObject(ms) as Calendar;
		}

        [DataMember(Name = "id")]
        public string Id { get; internal set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "created_time")]
        public string CreatedTime { get; set; }

        [DataMember(Name = "updated_time")]
        public string UpdatedTime { get; set; }

        [DataMember(Name = "from")]
        public User From { get; set; }

        [DataMember(Name = "is_default")]
        public bool IsDefault { get; set; }

        [DataMember(Name = "subscription_location")]
        public string SubscriptionLocation { get; set; }

        [DataMember(Name = "permissions")]
        public string Permissions { get; set; }
    }
}