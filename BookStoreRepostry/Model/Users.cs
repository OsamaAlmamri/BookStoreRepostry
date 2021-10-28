using System;
using System.Collections.Generic;

namespace StaticData.Model
{
    public partial class Users
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
