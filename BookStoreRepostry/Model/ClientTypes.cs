﻿using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class ClientTypes
    {
        public ClientTypes()
        {
            Clients = new HashSet<Clients>();
        }

        public long Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}