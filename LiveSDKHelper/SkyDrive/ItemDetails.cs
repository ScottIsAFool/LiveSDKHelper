using System;
using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public class ItemDetails
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "from")]
        public User From { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "parent_id")]
        public string ParentId { get; set; }
        [DataMember(Name = "size")]
        public int Size { get; set; }
        [DataMember(Name = "upload_location")]
        public string UploadLocation { get; set; }
        [DataMember(Name = "comments_count")]
        public int CommentsCount { get; set; }
        [DataMember(Name = "comments_enabled")]
        public bool CommentsEnabled { get; set; }
        [DataMember(Name = "is_embeddable")]
        public bool IsEmbeddable { get; set; }
        [DataMember(Name = "count")]
        public int Count { get; set; }
        [DataMember(Name = "link")]
        public string Link { get; set; }
        [DataMember(Name = "type")]
        public ItemType Type { get; set; }
        [DataMember(Name = "shared_with")]
        public SharedWith SharedWith { get; set; }
        [DataMember(Name = "created_time")]
        public DateTime CreatedTime { get; set; }
        [DataMember(Name = "updated_time")]
        public DateTime UpdatedTime { get; set; }
        [DataMember(Name = "source")]
        public string Source { get; set; }
    }
}