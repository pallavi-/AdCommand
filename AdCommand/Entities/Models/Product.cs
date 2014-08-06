using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Product
    {
        public Product()
        {
            this.AdPolicyMasters = new List<AdPolicyMaster>();
            this.AffiliateScripts = new List<AffiliateScript>();
            this.AssetScripts = new List<AssetScript>();
            this.Blacklists = new List<Blacklist>();
            this.BlacklistedIPs = new List<BlacklistedIP>();
            this.ConceptLinkPolicyMasters = new List<ConceptLinkPolicyMaster>();
            this.CSSPolicyMasters = new List<CSSPolicyMaster>();
            this.DDCMappings = new List<DDCMapping>();
            this.DefaultScriptPerProducts = new List<DefaultScriptPerProduct>();
            this.DisplayURLPolicyMasters = new List<DisplayURLPolicyMaster>();
            this.Distributors = new List<Distributor>();
            this.DistributorCodes = new List<DistributorCode>();
            this.DomainScripts = new List<DomainScript>();
            this.DomainScriptRevisions = new List<DomainScriptRevision>();
            this.ErrorRedirectDomains = new List<ErrorRedirectDomain>();
            this.Filters = new List<Filter>();
            this.HttpsDomains = new List<HttpsDomain>();
            this.Installs = new List<Install>();
            this.InterstitialScripts = new List<InterstitialScript>();
            this.LastUserActivities = new List<LastUserActivity>();
            this.MintCallLimits = new List<MintCallLimit>();
            this.MissedKeywords = new List<MissedKeyword>();
            this.NetseerUnits = new List<NetseerUnit>();
            this.ProxyDefaultScripts = new List<ProxyDefaultScript>();
            this.Settings = new List<Setting>();
            this.ToolbarEventLogs = new List<ToolbarEventLog>();
            this.UpdateSettings = new List<UpdateSetting>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string SiteURL { get; set; }
        public string Alias { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<AdPolicyMaster> AdPolicyMasters { get; set; }
        public virtual ICollection<AffiliateScript> AffiliateScripts { get; set; }
        public virtual ICollection<AssetScript> AssetScripts { get; set; }
        public virtual ICollection<Blacklist> Blacklists { get; set; }
        public virtual ICollection<BlacklistedIP> BlacklistedIPs { get; set; }
        public virtual ICollection<ConceptLinkPolicyMaster> ConceptLinkPolicyMasters { get; set; }
        public virtual ICollection<CSSPolicyMaster> CSSPolicyMasters { get; set; }
        public virtual ICollection<DDCMapping> DDCMappings { get; set; }
        public virtual ICollection<DefaultScriptPerProduct> DefaultScriptPerProducts { get; set; }
        public virtual ICollection<DisplayURLPolicyMaster> DisplayURLPolicyMasters { get; set; }
        public virtual ICollection<Distributor> Distributors { get; set; }
        public virtual ICollection<DistributorCode> DistributorCodes { get; set; }
        public virtual ICollection<DomainScript> DomainScripts { get; set; }
        public virtual ICollection<DomainScriptRevision> DomainScriptRevisions { get; set; }
        public virtual ICollection<ErrorRedirectDomain> ErrorRedirectDomains { get; set; }
        public virtual ICollection<Filter> Filters { get; set; }
        public virtual ICollection<HttpsDomain> HttpsDomains { get; set; }
        public virtual ICollection<Install> Installs { get; set; }
        public virtual ICollection<InterstitialScript> InterstitialScripts { get; set; }
        public virtual ICollection<LastUserActivity> LastUserActivities { get; set; }
        public virtual ICollection<MintCallLimit> MintCallLimits { get; set; }
        public virtual ICollection<MissedKeyword> MissedKeywords { get; set; }
        public virtual ICollection<NetseerUnit> NetseerUnits { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<ProxyDefaultScript> ProxyDefaultScripts { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<ToolbarEventLog> ToolbarEventLogs { get; set; }
        public virtual ICollection<UpdateSetting> UpdateSettings { get; set; }
    }
}
