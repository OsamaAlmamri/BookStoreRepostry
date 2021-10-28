using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class ProdigySystems
    {
        public ProdigySystems()
        {
            SystemsUsers = new HashSet<SystemsUsers>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DevelopmentTeam { get; set; }
        public string Note { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<SystemsUsers> SystemsUsers { get; set; }
    }
}
