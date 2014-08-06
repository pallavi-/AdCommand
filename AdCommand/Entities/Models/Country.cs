using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Country
    {
        public Country()
        {
            this.AdPolicyMasters = new List<AdPolicyMaster>();
            this.AssetScripts = new List<AssetScript>();
            this.ConceptLinkCSSPolicyMasters = new List<ConceptLinkCSSPolicyMaster>();
            this.ConceptLinkPolicyMasters = new List<ConceptLinkPolicyMaster>();
            this.CSSPolicyMasters = new List<CSSPolicyMaster>();
            this.DisplayURLPolicyMasters = new List<DisplayURLPolicyMaster>();
            this.DistributorCodes = new List<DistributorCode>();
            this.Filters = new List<Filter>();
            this.MintCallLimits = new List<MintCallLimit>();
            this.MismatchedAffiliates = new List<MismatchedAffiliate>();
            this.MismatchedAffiliates1 = new List<MismatchedAffiliate>();
            this.DomainScripts = new List<DomainScript>();
            this.DomainScriptRevisions = new List<DomainScriptRevision>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<AdPolicyMaster> AdPolicyMasters { get; set; }
        public virtual ICollection<AssetScript> AssetScripts { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyMaster> ConceptLinkCSSPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkPolicyMaster> ConceptLinkPolicyMasters { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<CSSPolicyMaster> CSSPolicyMasters { get; set; }
        public virtual ICollection<DisplayURLPolicyMaster> DisplayURLPolicyMasters { get; set; }
        public virtual ICollection<DistributorCode> DistributorCodes { get; set; }
        public virtual ICollection<Filter> Filters { get; set; }
        public virtual ICollection<MintCallLimit> MintCallLimits { get; set; }
        public virtual ICollection<MismatchedAffiliate> MismatchedAffiliates { get; set; }
        public virtual ICollection<MismatchedAffiliate> MismatchedAffiliates1 { get; set; }
        public virtual ICollection<DomainScript> DomainScripts { get; set; }
        public virtual ICollection<DomainScriptRevision> DomainScriptRevisions { get; set; }
    }
}
