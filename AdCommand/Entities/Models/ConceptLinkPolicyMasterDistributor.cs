using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class ConceptLinkPolicyMasterDistributor
    {
        public int ID { get; set; }
        public int ConceptLinkPolicyMasterID { get; set; }
        public int DistributorID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ConceptLinkPolicyMaster ConceptLinkPolicyMaster { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
