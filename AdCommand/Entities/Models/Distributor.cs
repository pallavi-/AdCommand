using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Distributor
    {
        public Distributor()
        {
            this.AdPolicyMasters = new List<AdPolicyMaster>();
            this.ConceptLinkCSSPolicyMasters = new List<ConceptLinkCSSPolicyMaster>();
            this.ConceptLinkPolicyMasterDistributors = new List<ConceptLinkPolicyMasterDistributor>();
            this.CSSPolicyMasters = new List<CSSPolicyMaster>();
            this.DisplayURLPolicyMasters = new List<DisplayURLPolicyMaster>();
            this.DistributorCodes = new List<DistributorCode>();
            this.FilterDistributorScripts = new List<FilterDistributorScript>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<AdPolicyMaster> AdPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyMaster> ConceptLinkCSSPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkPolicyMasterDistributor> ConceptLinkPolicyMasterDistributors { get; set; }
        public virtual ICollection<CSSPolicyMaster> CSSPolicyMasters { get; set; }
        public virtual ICollection<DisplayURLPolicyMaster> DisplayURLPolicyMasters { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<DistributorCode> DistributorCodes { get; set; }
        public virtual ICollection<FilterDistributorScript> FilterDistributorScripts { get; set; }
    }
}
