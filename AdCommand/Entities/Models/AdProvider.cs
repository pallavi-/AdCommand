using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class AdProvider
    {
        public AdProvider()
        {
            this.AdPolicyDetails = new List<AdPolicyDetail>();
            this.CSSPolicyMasterAdProviders = new List<CSSPolicyMasterAdProvider>();
            this.MintCallLimits = new List<MintCallLimit>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<AdPolicyDetail> AdPolicyDetails { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<CSSPolicyMasterAdProvider> CSSPolicyMasterAdProviders { get; set; }
        public virtual ICollection<MintCallLimit> MintCallLimits { get; set; }
    }
}
