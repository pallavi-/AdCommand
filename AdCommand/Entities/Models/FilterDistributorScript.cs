using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class FilterDistributorScript
    {
        public int ID { get; set; }
        public int DistributorID { get; set; }
        public long DomainScriptID { get; set; }
        public Nullable<int> FilterID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual DomainScript DomainScript { get; set; }
        public virtual Filter Filter { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
