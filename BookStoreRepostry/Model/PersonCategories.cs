using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class PersonCategories
    {
        public PersonCategories()
        {
            Persons = new HashSet<Persons>();
        }

        public long Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Persons> Persons { get; set; }
    }
}
