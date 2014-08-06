using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RRM.Entities.Models.Mapping;

namespace RRM.Entities.Models
{
    public partial class AdcommandContext : DbContext
    {
        static AdcommandContext()
        {
            Database.SetInitializer<AdcommandContext>(null);
        }

        public AdcommandContext()
            : base("Name=AdcommandContext")
        {
        }

        public DbSet<AdPolicyDetail> AdPolicyDetails { get; set; }
        public DbSet<AdPolicyMaster> AdPolicyMasters { get; set; }
        public DbSet<AdProvider> AdProviders { get; set; }
        public DbSet<AffiliateScript> AffiliateScripts { get; set; }
        public DbSet<AssetScript> AssetScripts { get; set; }
        public DbSet<BinFilesQueue> BinFilesQueues { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<BlacklistedDomain> BlacklistedDomains { get; set; }
        public DbSet<BlacklistedIP> BlacklistedIPs { get; set; }
        public DbSet<ConceptLinkCSSPolicyDetail> ConceptLinkCSSPolicyDetails { get; set; }
        public DbSet<ConceptLinkCSSPolicyMaster> ConceptLinkCSSPolicyMasters { get; set; }
        public DbSet<ConceptLinkPolicyMaster> ConceptLinkPolicyMasters { get; set; }
        public DbSet<ConceptLinkPolicyMasterDistributor> ConceptLinkPolicyMasterDistributors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CSSMaster> CSSMasters { get; set; }
        public DbSet<CSSPolicyDetail> CSSPolicyDetails { get; set; }
        public DbSet<CSSPolicyMaster> CSSPolicyMasters { get; set; }
        public DbSet<CSSPolicyMasterAdProvider> CSSPolicyMasterAdProviders { get; set; }
        public DbSet<DDCMapping> DDCMappings { get; set; }
        public DbSet<DefaultScriptPerProduct> DefaultScriptPerProducts { get; set; }
        public DbSet<DisplayURLPolicyMaster> DisplayURLPolicyMasters { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<DistributorCode> DistributorCodes { get; set; }
        public DbSet<DistributorCodeAssetScript> DistributorCodeAssetScripts { get; set; }
        public DbSet<DomainScript> DomainScripts { get; set; }
        public DbSet<DomainScriptRevision> DomainScriptRevisions { get; set; }
        public DbSet<ErrorRedirectDomain> ErrorRedirectDomains { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<FilterDistributor> FilterDistributors { get; set; }
        public DbSet<FilterDistributorScript> FilterDistributorScripts { get; set; }
        public DbSet<HelperScript> HelperScripts { get; set; }
        public DbSet<HttpsDomain> HttpsDomains { get; set; }
        public DbSet<Install> Installs { get; set; }
        public DbSet<InterstitialLandingSite> InterstitialLandingSites { get; set; }
        public DbSet<InterstitialScript> InterstitialScripts { get; set; }
        public DbSet<InterstitialScriptDomain> InterstitialScriptDomains { get; set; }
        public DbSet<LastUserActivity> LastUserActivities { get; set; }
        public DbSet<MintCallLimit> MintCallLimits { get; set; }
        public DbSet<MismatchedAffiliate> MismatchedAffiliates { get; set; }
        public DbSet<MissedKeyword> MissedKeywords { get; set; }
        public DbSet<NamiDefaultKeyword> NamiDefaultKeywords { get; set; }
        public DbSet<NamiMapping> NamiMappings { get; set; }
        public DbSet<NetseerDistributorCode> NetseerDistributorCodes { get; set; }
        public DbSet<NetseerDomain> NetseerDomains { get; set; }
        public DbSet<NetseerLandingLink> NetseerLandingLinks { get; set; }
        public DbSet<NetseerUnit> NetseerUnits { get; set; }
        public DbSet<PopUpAd> PopUpAds { get; set; }
        public DbSet<PopUpDomain> PopUpDomains { get; set; }
        public DbSet<PopUpLandingSite> PopUpLandingSites { get; set; }
        public DbSet<PopUpPerDistributor> PopUpPerDistributors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProxyDefaultScript> ProxyDefaultScripts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<TestingGuid> TestingGuids { get; set; }
        public DbSet<ToolbarEventLog> ToolbarEventLogs { get; set; }
        public DbSet<UpdateAssignment> UpdateAssignments { get; set; }
        public DbSet<UpdateSetting> UpdateSettings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WhitelistedSubDomain> WhitelistedSubDomains { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdPolicyDetailMap());
            modelBuilder.Configurations.Add(new AdPolicyMasterMap());
            modelBuilder.Configurations.Add(new AdProviderMap());
            modelBuilder.Configurations.Add(new AffiliateScriptMap());
            modelBuilder.Configurations.Add(new AssetScriptMap());
            modelBuilder.Configurations.Add(new BinFilesQueueMap());
            modelBuilder.Configurations.Add(new BlacklistMap());
            modelBuilder.Configurations.Add(new BlacklistedDomainMap());
            modelBuilder.Configurations.Add(new BlacklistedIPMap());
            modelBuilder.Configurations.Add(new ConceptLinkCSSPolicyDetailMap());
            modelBuilder.Configurations.Add(new ConceptLinkCSSPolicyMasterMap());
            modelBuilder.Configurations.Add(new ConceptLinkPolicyMasterMap());
            modelBuilder.Configurations.Add(new ConceptLinkPolicyMasterDistributorMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CSSMasterMap());
            modelBuilder.Configurations.Add(new CSSPolicyDetailMap());
            modelBuilder.Configurations.Add(new CSSPolicyMasterMap());
            modelBuilder.Configurations.Add(new CSSPolicyMasterAdProviderMap());
            modelBuilder.Configurations.Add(new DDCMappingMap());
            modelBuilder.Configurations.Add(new DefaultScriptPerProductMap());
            modelBuilder.Configurations.Add(new DisplayURLPolicyMasterMap());
            modelBuilder.Configurations.Add(new DistributorMap());
            modelBuilder.Configurations.Add(new DistributorCodeMap());
            modelBuilder.Configurations.Add(new DistributorCodeAssetScriptMap());
            modelBuilder.Configurations.Add(new DomainScriptMap());
            modelBuilder.Configurations.Add(new DomainScriptRevisionMap());
            modelBuilder.Configurations.Add(new ErrorRedirectDomainMap());
            modelBuilder.Configurations.Add(new FilterMap());
            modelBuilder.Configurations.Add(new FilterDistributorMap());
            modelBuilder.Configurations.Add(new FilterDistributorScriptMap());
            modelBuilder.Configurations.Add(new HelperScriptMap());
            modelBuilder.Configurations.Add(new HttpsDomainMap());
            modelBuilder.Configurations.Add(new InstallMap());
            modelBuilder.Configurations.Add(new InterstitialLandingSiteMap());
            modelBuilder.Configurations.Add(new InterstitialScriptMap());
            modelBuilder.Configurations.Add(new InterstitialScriptDomainMap());
            modelBuilder.Configurations.Add(new LastUserActivityMap());
            modelBuilder.Configurations.Add(new MintCallLimitMap());
            modelBuilder.Configurations.Add(new MismatchedAffiliateMap());
            modelBuilder.Configurations.Add(new MissedKeywordMap());
            modelBuilder.Configurations.Add(new NamiDefaultKeywordMap());
            modelBuilder.Configurations.Add(new NamiMappingMap());
            modelBuilder.Configurations.Add(new NetseerDistributorCodeMap());
            modelBuilder.Configurations.Add(new NetseerDomainMap());
            modelBuilder.Configurations.Add(new NetseerLandingLinkMap());
            modelBuilder.Configurations.Add(new NetseerUnitMap());
            modelBuilder.Configurations.Add(new PopUpAdMap());
            modelBuilder.Configurations.Add(new PopUpDomainMap());
            modelBuilder.Configurations.Add(new PopUpLandingSiteMap());
            modelBuilder.Configurations.Add(new PopUpPerDistributorMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProxyDefaultScriptMap());
            modelBuilder.Configurations.Add(new SettingMap());
            modelBuilder.Configurations.Add(new StatMap());
            modelBuilder.Configurations.Add(new TestingGuidMap());
            modelBuilder.Configurations.Add(new ToolbarEventLogMap());
            modelBuilder.Configurations.Add(new UpdateAssignmentMap());
            modelBuilder.Configurations.Add(new UpdateSettingMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new WhitelistedSubDomainMap());
        }
    }
}
