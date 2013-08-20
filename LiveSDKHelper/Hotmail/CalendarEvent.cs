using System.Runtime.Serialization;
using LiveSDKHelper.SkyDrive;
using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Globalization;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class CalendarEvent
    {
		public CalendarEvent() { }

		public static CalendarEvent FromJson(string json)
		{
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CalendarEvent));
			using(var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
				return ser.ReadObject(ms) as CalendarEvent;
		}

        [DataMember(Name = "id")]
        public string Id { get; internal set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "is_all_day_event")]
        public bool IsAllDayEvent { get; set; }

        [DataMember(Name = "start_time")]
        internal string StartTimeInternal { get; set; }

		private DateTime? m_StartTime;

		public DateTime StartTime
		{
			get {
				if (!m_StartTime.HasValue)
				{
					if (string.IsNullOrEmpty(StartTimeInternal))
						return default(DateTime);
					m_StartTime = DateTime.Parse(StartTimeInternal, CultureInfo.InvariantCulture);
				}
				return m_StartTime.Value;
			}
			set
			{
				m_StartTime = value; 
				StartTimeInternal = value.ToString(CultureInfo.InvariantCulture);
			}
		}

		[DataMember(Name = "end_time")]
		internal string EndTimeInternal { get; set; }

		private DateTime? m_EndTime;

		public DateTime EndTime
		{
			get
			{
				if (!m_EndTime.HasValue)
				{
					if (string.IsNullOrEmpty(EndTimeInternal))
						return default(DateTime);
					m_EndTime = DateTime.Parse(EndTimeInternal, CultureInfo.InvariantCulture);
				}
				return m_EndTime.Value;
			}
			set
			{
				m_EndTime = value;
				EndTimeInternal = value.ToString(System.Globalization.CultureInfo.InvariantCulture);
			}
		}
   }
}