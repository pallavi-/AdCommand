using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class NamiMapping
    {
        public int ID { get; set; }
        public int SID { get; set; }
        public int DistributorCodeID { get; set; }
        public string Auth { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual DistributorCode DistributorCode { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
