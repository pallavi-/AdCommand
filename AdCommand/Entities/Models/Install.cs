using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Install
    {
        public int ID { get; set; }
        public System.Guid Guid { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string AffiliateID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
