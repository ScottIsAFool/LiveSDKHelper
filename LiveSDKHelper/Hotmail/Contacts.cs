using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Contacts
    {
        [DataMember(Name = "data")]
        public List<Contact> Items { get; set; }
    }
}