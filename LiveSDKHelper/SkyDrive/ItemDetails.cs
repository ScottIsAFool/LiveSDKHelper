using System;
using System.Collections.Generic;
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
        [DataMember(Name = "tags_count")]
        public int? TagsCount { get; set; }
        [DataMember(Name = "tags_enabled")]
        public bool? TagsEnabled { get; set; }
        [DataMember(Name = "picture")]
        public string Picture { get; set; }
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; }
        [DataMember(Name = "when_taken")]
        public DateTime? WhenTaken { get; set; }
        [DataMember(Name = "height")]
        public int? Height { get; set; }
        [DataMember(Name = "width")]
        public int? Width { get; set; }
        [DataMember(Name = "location")]
        public object Location { get; set; }
        [DataMember(Name = "camera_make")]
        public object CameraMake { get; set; }
        [DataMember(Name = "camera_model")]
        public object CameraModel { get; set; }
        [DataMember(Name = "focal_ratio")]
        public int? FocalRatio { get; set; }
        [DataMember(Name = "focal_length")]
        public int? FocalLength { get; set; }
        [DataMember(Name = "exposure_numerator")]
        public int? ExposureNumerator { get; set; }
        [DataMember(Name = "exposure_denominator")]
        public int? ExposureDenominator { get; set; }
    }
}