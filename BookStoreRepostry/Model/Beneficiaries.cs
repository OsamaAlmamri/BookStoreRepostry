using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class Beneficiaries
    {
        public long Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string IdentityType { get; set; }
        public string IdentityId { get; set; }
        public string CellPhone { get; set; }
        public string CellPhone2 { get; set; }
        public long? CurrentSiteId { get; set; }
        public string EMail { get; set; }
        public bool? Status { get; set; }
        public string BeneficiaryCode { get; set; }
        public string CreationMetadata { get; set; }
        public string Address { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual GeoData CurrentSite { get; set; }
    }
}
