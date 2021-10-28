using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class Projects
    {
        public long Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public long? ProgrammeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Programmes Programme { get; set; }
    }
}
