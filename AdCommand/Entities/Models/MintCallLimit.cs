using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class MintCallLimit
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> DistributorCodeID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Domain { get; set; }
        public Nullable<int> AdProviderID { get; set; }
        public Nullable<int> Limit { get; set; }
        public Nullable<int> TimeDiff { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual AdProvider AdProvider { get; set; }
        public virtual Country Country { get; set; }
        public virtual DistributorCode DistributorCode { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
