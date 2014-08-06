using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class User
    {
        public User()
        {
            this.AdPolicyDetails = new List<AdPolicyDetail>();
            this.AdPolicyDetails1 = new List<AdPolicyDetail>();
            this.AdPolicyMasters = new List<AdPolicyMaster>();
            this.AdPolicyMasters1 = new List<AdPolicyMaster>();
            this.AdProviders = new List<AdProvider>();
            this.AdProviders1 = new List<AdProvider>();
            this.AffiliateScripts = new List<AffiliateScript>();
            this.AffiliateScripts1 = new List<AffiliateScript>();
            this.AssetScripts = new List<AssetScript>();
            this.AssetScripts1 = new List<AssetScript>();
            this.BinFilesQueues = new List<BinFilesQueue>();
            this.BinFilesQueues1 = new List<BinFilesQueue>();
            this.Blacklists = new List<Blacklist>();
            this.Blacklists1 = new List<Blacklist>();
            this.BlacklistedDomains = new List<BlacklistedDomain>();
            this.BlacklistedDomains1 = new List<BlacklistedDomain>();
            this.BlacklistedIPs = new List<BlacklistedIP>();
            this.BlacklistedIPs1 = new List<BlacklistedIP>();
            this.ConceptLinkCSSPolicyDetails = new List<ConceptLinkCSSPolicyDetail>();
            this.ConceptLinkCSSPolicyDetails1 = new List<ConceptLinkCSSPolicyDetail>();
            this.ConceptLinkCSSPolicyMasters = new List<ConceptLinkCSSPolicyMaster>();
            this.ConceptLinkCSSPolicyMasters1 = new List<ConceptLinkCSSPolicyMaster>();
            this.ConceptLinkPolicyMasters = new List<ConceptLinkPolicyMaster>();
            this.ConceptLinkPolicyMasters1 = new List<ConceptLinkPolicyMaster>();
            this.ConceptLinkPolicyMasterDistributors = new List<ConceptLinkPolicyMasterDistributor>();
            this.ConceptLinkPolicyMasterDistributors1 = new List<ConceptLinkPolicyMasterDistributor>();
            this.Countries = new List<Country>();
            this.Countries1 = new List<Country>();
            this.CSSMasters = new List<CSSMaster>();
            this.CSSMasters1 = new List<CSSMaster>();
            this.CSSPolicyDetails = new List<CSSPolicyDetail>();
            this.CSSPolicyDetails1 = new List<CSSPolicyDetail>();
            this.CSSPolicyMasters = new List<CSSPolicyMaster>();
            this.CSSPolicyMasters1 = new List<CSSPolicyMaster>();
            this.CSSPolicyMasterAdProviders = new List<CSSPolicyMasterAdProvider>();
            this.CSSPolicyMasterAdProviders1 = new List<CSSPolicyMasterAdProvider>();
            this.DDCMappings = new List<DDCMapping>();
            this.DDCMappings1 = new List<DDCMapping>();
            this.DefaultScriptPerProducts = new List<DefaultScriptPerProduct>();
            this.DefaultScriptPerProducts1 = new List<DefaultScriptPerProduct>();
            this.DisplayURLPolicyMasters = new List<DisplayURLPolicyMaster>();
            this.DisplayURLPolicyMasters1 = new List<DisplayURLPolicyMaster>();
            this.Distributors = new List<Distributor>();
            this.Distributors1 = new List<Distributor>();
            this.DistributorCodes = new List<DistributorCode>();
            this.DistributorCodes1 = new List<DistributorCode>();
            this.DistributorCodeAssetScripts = new List<DistributorCodeAssetScript>();
            this.DistributorCodeAssetScripts1 = new List<DistributorCodeAssetScript>();
            this.DomainScripts = new List<DomainScript>();
            this.DomainScripts1 = new List<DomainScript>();
            this.DomainScriptRevisions = new List<DomainScriptRevision>();
            this.DomainScriptRevisions1 = new List<DomainScriptRevision>();
            this.ErrorRedirectDomains = new List<ErrorRedirectDomain>();
            this.ErrorRedirectDomains1 = new List<ErrorRedirectDomain>();
            this.Filters = new List<Filter>();
            this.Filters1 = new List<Filter>();
            this.FilterDistributors = new List<FilterDistributor>();
            this.FilterDistributors1 = new List<FilterDistributor>();
            this.FilterDistributorScripts = new List<FilterDistributorScript>();
            this.FilterDistributorScripts1 = new List<FilterDistributorScript>();
            this.HelperScripts = new List<HelperScript>();
            this.HelperScripts1 = new List<HelperScript>();
            this.HttpsDomains = new List<HttpsDomain>();
            this.HttpsDomains1 = new List<HttpsDomain>();
            this.Installs = new List<Install>();
            this.Installs1 = new List<Install>();
            this.InterstitialLandingSites = new List<InterstitialLandingSite>();
            this.InterstitialLandingSites1 = new List<InterstitialLandingSite>();
            this.InterstitialScripts = new List<InterstitialScript>();
            this.InterstitialScripts1 = new List<InterstitialScript>();
            this.InterstitialScriptDomains = new List<InterstitialScriptDomain>();
            this.InterstitialScriptDomains1 = new List<InterstitialScriptDomain>();
            this.LastUserActivities = new List<LastUserActivity>();
            this.LastUserActivities1 = new List<LastUserActivity>();
            this.MintCallLimits = new List<MintCallLimit>();
            this.MintCallLimits1 = new List<MintCallLimit>();
            this.MismatchedAffiliates = new List<MismatchedAffiliate>();
            this.MismatchedAffiliates1 = new List<MismatchedAffiliate>();
            this.MissedKeywords = new List<MissedKeyword>();
            this.MissedKeywords1 = new List<MissedKeyword>();
            this.NamiDefaultKeywords = new List<NamiDefaultKeyword>();
            this.NamiDefaultKeywords1 = new List<NamiDefaultKeyword>();
            this.NamiMappings = new List<NamiMapping>();
            this.NamiMappings1 = new List<NamiMapping>();
            this.NetseerDistributorCodes = new List<NetseerDistributorCode>();
            this.NetseerDistributorCodes1 = new List<NetseerDistributorCode>();
            this.NetseerDomains = new List<NetseerDomain>();
            this.NetseerDomains1 = new List<NetseerDomain>();
            this.NetseerLandingLinks = new List<NetseerLandingLink>();
            this.NetseerLandingLinks1 = new List<NetseerLandingLink>();
            this.NetseerUnits = new List<NetseerUnit>();
            this.NetseerUnits1 = new List<NetseerUnit>();
            this.PopUpAds = new List<PopUpAd>();
            this.PopUpAds1 = new List<PopUpAd>();
            this.PopUpDomains = new List<PopUpDomain>();
            this.PopUpDomains1 = new List<PopUpDomain>();
            this.PopUpLandingSites = new List<PopUpLandingSite>();
            this.PopUpLandingSites1 = new List<PopUpLandingSite>();
            this.PopUpPerDistributors = new List<PopUpPerDistributor>();
            this.PopUpPerDistributors1 = new List<PopUpPerDistributor>();
            this.Products = new List<Product>();
            this.Products1 = new List<Product>();
            this.ProxyDefaultScripts = new List<ProxyDefaultScript>();
            this.ProxyDefaultScripts1 = new List<ProxyDefaultScript>();
            this.Settings = new List<Setting>();
            this.Settings1 = new List<Setting>();
            this.Stats = new List<Stat>();
            this.Stats1 = new List<Stat>();
            this.TestingGuids = new List<TestingGuid>();
            this.TestingGuids1 = new List<TestingGuid>();
            this.ToolbarEventLogs = new List<ToolbarEventLog>();
            this.ToolbarEventLogs1 = new List<ToolbarEventLog>();
            this.UpdateAssignments = new List<UpdateAssignment>();
            this.UpdateAssignments1 = new List<UpdateAssignment>();
            this.UpdateSettings = new List<UpdateSetting>();
            this.UpdateSettings1 = new List<UpdateSetting>();
            this.WhitelistedSubDomains = new List<WhitelistedSubDomain>();
            this.WhitelistedSubDomains1 = new List<WhitelistedSubDomain>();
        }

        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public virtual ICollection<AdPolicyDetail> AdPolicyDetails { get; set; }
        public virtual ICollection<AdPolicyDetail> AdPolicyDetails1 { get; set; }
        public virtual ICollection<AdPolicyMaster> AdPolicyMasters { get; set; }
        public virtual ICollection<AdPolicyMaster> AdPolicyMasters1 { get; set; }
        public virtual ICollection<AdProvider> AdProviders { get; set; }
        public virtual ICollection<AdProvider> AdProviders1 { get; set; }
        public virtual ICollection<AffiliateScript> AffiliateScripts { get; set; }
        public virtual ICollection<AffiliateScript> AffiliateScripts1 { get; set; }
        public virtual ICollection<AssetScript> AssetScripts { get; set; }
        public virtual ICollection<AssetScript> AssetScripts1 { get; set; }
        public virtual ICollection<BinFilesQueue> BinFilesQueues { get; set; }
        public virtual ICollection<BinFilesQueue> BinFilesQueues1 { get; set; }
        public virtual ICollection<Blacklist> Blacklists { get; set; }
        public virtual ICollection<Blacklist> Blacklists1 { get; set; }
        public virtual ICollection<BlacklistedDomain> BlacklistedDomains { get; set; }
        public virtual ICollection<BlacklistedDomain> BlacklistedDomains1 { get; set; }
        public virtual ICollection<BlacklistedIP> BlacklistedIPs { get; set; }
        public virtual ICollection<BlacklistedIP> BlacklistedIPs1 { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyDetail> ConceptLinkCSSPolicyDetails { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyDetail> ConceptLinkCSSPolicyDetails1 { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyMaster> ConceptLinkCSSPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyMaster> ConceptLinkCSSPolicyMasters1 { get; set; }
        public virtual ICollection<ConceptLinkPolicyMaster> ConceptLinkPolicyMasters { get; set; }
        public virtual ICollection<ConceptLinkPolicyMaster> ConceptLinkPolicyMasters1 { get; set; }
        public virtual ICollection<ConceptLinkPolicyMasterDistributor> ConceptLinkPolicyMasterDistributors { get; set; }
        public virtual ICollection<ConceptLinkPolicyMasterDistributor> ConceptLinkPolicyMasterDistributors1 { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Country> Countries1 { get; set; }
        public virtual ICollection<CSSMaster> CSSMasters { get; set; }
        public virtual ICollection<CSSMaster> CSSMasters1 { get; set; }
        public virtual ICollection<CSSPolicyDetail> CSSPolicyDetails { get; set; }
        public virtual ICollection<CSSPolicyDetail> CSSPolicyDetails1 { get; set; }
        public virtual ICollection<CSSPolicyMaster> CSSPolicyMasters { get; set; }
        public virtual ICollection<CSSPolicyMaster> CSSPolicyMasters1 { get; set; }
        public virtual ICollection<CSSPolicyMasterAdProvider> CSSPolicyMasterAdProviders { get; set; }
        public virtual ICollection<CSSPolicyMasterAdProvider> CSSPolicyMasterAdProviders1 { get; set; }
        public virtual ICollection<DDCMapping> DDCMappings { get; set; }
        public virtual ICollection<DDCMapping> DDCMappings1 { get; set; }
        public virtual ICollection<DefaultScriptPerProduct> DefaultScriptPerProducts { get; set; }
        public virtual ICollection<DefaultScriptPerProduct> DefaultScriptPerProducts1 { get; set; }
        public virtual ICollection<DisplayURLPolicyMaster> DisplayURLPolicyMasters { get; set; }
        public virtual ICollection<DisplayURLPolicyMaster> DisplayURLPolicyMasters1 { get; set; }
        public virtual ICollection<Distributor> Distributors { get; set; }
        public virtual ICollection<Distributor> Distributors1 { get; set; }
        public virtual ICollection<DistributorCode> DistributorCodes { get; set; }
        public virtual ICollection<DistributorCode> DistributorCodes1 { get; set; }
        public virtual ICollection<DistributorCodeAssetScript> DistributorCodeAssetScripts { get; set; }
        public virtual ICollection<DistributorCodeAssetScript> DistributorCodeAssetScripts1 { get; set; }
        public virtual ICollection<DomainScript> DomainScripts { get; set; }
        public virtual ICollection<DomainScript> DomainScripts1 { get; set; }
        public virtual ICollection<DomainScriptRevision> DomainScriptRevisions { get; set; }
        public virtual ICollection<DomainScriptRevision> DomainScriptRevisions1 { get; set; }
        public virtual ICollection<ErrorRedirectDomain> ErrorRedirectDomains { get; set; }
        public virtual ICollection<ErrorRedirectDomain> ErrorRedirectDomains1 { get; set; }
        public virtual ICollection<Filter> Filters { get; set; }
        public virtual ICollection<Filter> Filters1 { get; set; }
        public virtual ICollection<FilterDistributor> FilterDistributors { get; set; }
        public virtual ICollection<FilterDistributor> FilterDistributors1 { get; set; }
        public virtual ICollection<FilterDistributorScript> FilterDistributorScripts { get; set; }
        public virtual ICollection<FilterDistributorScript> FilterDistributorScripts1 { get; set; }
        public virtual ICollection<HelperScript> HelperScripts { get; set; }
        public virtual ICollection<HelperScript> HelperScripts1 { get; set; }
        public virtual ICollection<HttpsDomain> HttpsDomains { get; set; }
        public virtual ICollection<HttpsDomain> HttpsDomains1 { get; set; }
        public virtual ICollection<Install> Installs { get; set; }
        public virtual ICollection<Install> Installs1 { get; set; }
        public virtual ICollection<InterstitialLandingSite> InterstitialLandingSites { get; set; }
        public virtual ICollection<InterstitialLandingSite> InterstitialLandingSites1 { get; set; }
        public virtual ICollection<InterstitialScript> InterstitialScripts { get; set; }
        public virtual ICollection<InterstitialScript> InterstitialScripts1 { get; set; }
        public virtual ICollection<InterstitialScriptDomain> InterstitialScriptDomains { get; set; }
        public virtual ICollection<InterstitialScriptDomain> InterstitialScriptDomains1 { get; set; }
        public virtual ICollection<LastUserActivity> LastUserActivities { get; set; }
        public virtual ICollection<LastUserActivity> LastUserActivities1 { get; set; }
        public virtual ICollection<MintCallLimit> MintCallLimits { get; set; }
        public virtual ICollection<MintCallLimit> MintCallLimits1 { get; set; }
        public virtual ICollection<MismatchedAffiliate> MismatchedAffiliates { get; set; }
        public virtual ICollection<MismatchedAffiliate> MismatchedAffiliates1 { get; set; }
        public virtual ICollection<MissedKeyword> MissedKeywords { get; set; }
        public virtual ICollection<MissedKeyword> MissedKeywords1 { get; set; }
        public virtual ICollection<NamiDefaultKeyword> NamiDefaultKeywords { get; set; }
        public virtual ICollection<NamiDefaultKeyword> NamiDefaultKeywords1 { get; set; }
        public virtual ICollection<NamiMapping> NamiMappings { get; set; }
        public virtual ICollection<NamiMapping> NamiMappings1 { get; set; }
        public virtual ICollection<NetseerDistributorCode> NetseerDistributorCodes { get; set; }
        public virtual ICollection<NetseerDistributorCode> NetseerDistributorCodes1 { get; set; }
        public virtual ICollection<NetseerDomain> NetseerDomains { get; set; }
        public virtual ICollection<NetseerDomain> NetseerDomains1 { get; set; }
        public virtual ICollection<NetseerLandingLink> NetseerLandingLinks { get; set; }
        public virtual ICollection<NetseerLandingLink> NetseerLandingLinks1 { get; set; }
        public virtual ICollection<NetseerUnit> NetseerUnits { get; set; }
        public virtual ICollection<NetseerUnit> NetseerUnits1 { get; set; }
        public virtual ICollection<PopUpAd> PopUpAds { get; set; }
        public virtual ICollection<PopUpAd> PopUpAds1 { get; set; }
        public virtual ICollection<PopUpDomain> PopUpDomains { get; set; }
        public virtual ICollection<PopUpDomain> PopUpDomains1 { get; set; }
        public virtual ICollection<PopUpLandingSite> PopUpLandingSites { get; set; }
        public virtual ICollection<PopUpLandingSite> PopUpLandingSites1 { get; set; }
        public virtual ICollection<PopUpPerDistributor> PopUpPerDistributors { get; set; }
        public virtual ICollection<PopUpPerDistributor> PopUpPerDistributors1 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Product> Products1 { get; set; }
        public virtual ICollection<ProxyDefaultScript> ProxyDefaultScripts { get; set; }
        public virtual ICollection<ProxyDefaultScript> ProxyDefaultScripts1 { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<Setting> Settings1 { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
        public virtual ICollection<Stat> Stats1 { get; set; }
        public virtual ICollection<TestingGuid> TestingGuids { get; set; }
        public virtual ICollection<TestingGuid> TestingGuids1 { get; set; }
        public virtual ICollection<ToolbarEventLog> ToolbarEventLogs { get; set; }
        public virtual ICollection<ToolbarEventLog> ToolbarEventLogs1 { get; set; }
        public virtual ICollection<UpdateAssignment> UpdateAssignments { get; set; }
        public virtual ICollection<UpdateAssignment> UpdateAssignments1 { get; set; }
        public virtual ICollection<UpdateSetting> UpdateSettings { get; set; }
        public virtual ICollection<UpdateSetting> UpdateSettings1 { get; set; }
       // public virtual User Users1 { get; set; }
        //public virtual User User1 { get; set; }
        public virtual ICollection<WhitelistedSubDomain> WhitelistedSubDomains { get; set; }
        public virtual ICollection<WhitelistedSubDomain> WhitelistedSubDomains1 { get; set; }
    }
}
