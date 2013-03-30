using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    public class Comments
    {
        [DataMember(Name = "data")]
        public List<Comment> Items { get; set; }
    }
}