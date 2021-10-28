using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class FdbTypes
    {
        public FdbTypes()
        {
            Fdbs = new HashSet<Fdbs>();
        }

        public long Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Fdbs> Fdbs { get; set; }
    }
}
