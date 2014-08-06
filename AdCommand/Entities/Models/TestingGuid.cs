using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class TestingGuid
    {
        public int ID { get; set; }
        public string Guid { get; set; }
        public System.DateTime InstallDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
