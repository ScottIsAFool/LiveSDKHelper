using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Calendars
    {
 		public Calendars() { }

		public static Calendars FromJson(string json)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Calendars));
			using(var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
				return ser.ReadObject(ms) as Calendars;
		}

		[DataMember(Name = "data")]
        public List<Calendar> Items { get; internal set; }
    }
}