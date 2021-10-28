using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class Fdbs
    {
        public long Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string FdpCode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Elevation { get; set; }
        public bool? Status { get; set; }
        public string ProdigyCode { get; set; }
        public string CreationMetadata { get; set; }
        public long? FdpTypeId { get; set; }
        public long? SiteId { get; set; }
        public string Address { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual FdbTypes FdpType { get; set; }
        public virtual GeoData Site { get; set; }
    }
}
