using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "width")]
        public int Width { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "type")]
        public ImageType Type { get; set; }
    }
}