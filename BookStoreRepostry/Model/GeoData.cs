using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class GeoData
    {
        public GeoData()
        {
            Beneficiaries = new HashSet<Beneficiaries>();
            Fdbs = new HashSet<Fdbs>();
            Persons = new HashSet<Persons>();
        }

        public long SiteId { get; set; }
        public string SiteCode { get; set; }
        public string ParentCode { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public string PlaceCode { get; set; }
        public long? CountryId { get; set; }
        public long? SiteType { get; set; }
        public long? ParentId { get; set; }
        public bool? Isparent { get; set; }
        public long? SiteLevel { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Beneficiaries> Beneficiaries { get; set; }
        public virtual ICollection<Fdbs> Fdbs { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
    }
}
