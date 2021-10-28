using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class Logs
    {
        public long Id { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public long EntityId { get; set; }
        public string EntityType { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
