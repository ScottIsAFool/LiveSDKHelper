using System.Runtime.Serialization;

namespace LiveSDKHelper.Hotmail
{
    [DataContract]
    public class Contact
    {
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }
        [DataMember(Name = "last_name")]
        public string LastName { get; set; }
    }
}
