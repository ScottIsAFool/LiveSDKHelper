using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Contacts
    {
		public Contacts() { }

		public static Contacts FromJson(string json)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Contacts));
			using(var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
				return ser.ReadObject(ms) as Contacts;
		}

		[DataMember(Name = "data")]
        public List<Contact> Items { get; set; }
    }
}