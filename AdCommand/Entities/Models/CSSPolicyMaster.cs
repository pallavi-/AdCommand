using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class CSSPolicyMaster
    {
        public CSSPolicyMaster()
        {
            this.CSSPolicyDetails = new List<CSSPolicyDetail>();
            this.CSSPolicyMasterAdProviders = new List<CSSPolicyMasterAdProvider>();
        }

        public int ID { get; set; }
        public long DomainScriptID { get; set; }
        public int DistributorID { get; set; }
        public int CountryID { get; set; }
        public int ProductID { get; set; }
        public bool IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<CSSPolicyDetail> CSSPolicyDetails { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual Product Product { get; set; }
        public virtual DomainScript DomainScript { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<CSSPolicyMasterAdProvider> CSSPolicyMasterAdProviders { get; set; }
    }
}
