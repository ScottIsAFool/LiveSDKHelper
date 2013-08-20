using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class CalendarEvents
    {
		public CalendarEvents() { }

		public static CalendarEvents FromJson(string json)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CalendarEvents));
			using(var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
				return ser.ReadObject(ms) as CalendarEvents;
		}

		[DataMember(Name = "data")]
        public List<CalendarEvent> Items { get; internal set; }
    }
}