using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class DomainScript
    {
        public DomainScript()
        {
            this.AdPolicyMasters = new List<AdPolicyMaster>();
            this.ConceptLinkCSSPolicyMasters = new List<ConceptLinkCSSPolicyMaster>();
            this.ConceptLinkPolicyMasters = new List<ConceptLinkPolicyMaster>();
            this.CSSPolicyMasters = new List<CSSPolicyMaster>();
            this.DefaultScriptPerProducts = new List<DefaultScriptPerProduct>();
            this.DisplayURLPolicyMasters = new List<DisplayURLPolicyMaster>();
            this.FilterDistributorScripts = new List<FilterDistributorScript>();
            this.DomainScriptRevisions = new List<DomainScriptRevision>();
        }

        public long ID { get; set; }
        public string URLPattern { get; set; }
        public string Script { get; set; }
        public string Html { get; set; }
        public string Style { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<System.Guid> RowID { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Created { get; set; }
        public string Version { get; set; }
        public string ChangeLog { get; set; }
        public virtual ICollection<AdPolicyMaster> AdPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyMaster> ConceptLinkCSSPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkPolicyMaster> ConceptLinkPolicyMasters { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<CSSPolicyMaster> CSSPolicyMasters { get; set; }
        public virtual ICollection<DefaultScriptPerProduct> DefaultScriptPerProducts { get; set; }
        public virtual ICollection<DisplayURLPolicyMaster> DisplayURLPolicyMasters { get; set; }
        public virtual ICollection<FilterDistributorScript> FilterDistributorScripts { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<DomainScriptRevision> DomainScriptRevisions { get; set; }
    }
}
