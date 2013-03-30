using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class FolderDetails
    {
        [DataMember(Name = "data")]
        public List<ItemDetails> Items { get; set; }
    }
}
