using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class MismatchedAffiliate
    {
        public int ID { get; set; }
        public string AffiliateID { get; set; }
        public int OriginalCountryID { get; set; }
        public int NewCountryID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Country Country { get; set; }
        public virtual Country Country1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
