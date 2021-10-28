using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class SystemsUsers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? SystemId { get; set; }
        public long? UserId { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ProdigySystems System { get; set; }
    }
}
