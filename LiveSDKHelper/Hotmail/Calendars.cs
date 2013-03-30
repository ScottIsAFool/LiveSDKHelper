using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Calendars
    {
        [DataMember(Name = "data")]
        public List<Calendar> Items { get; set; }
    }
}