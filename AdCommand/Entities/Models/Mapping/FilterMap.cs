using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class FilterMap : EntityTypeConfiguration<Filter>
    {
        public FilterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            // Table & Column Mappings
            this.ToTable("Filter");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.DateType).HasColumnName("DateType");
            this.Property(t => t.UserList).HasColumnName("UserList");
            this.Property(t => t.DomainType).HasColumnName("DomainType");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DaysAfterUserInstall).HasColumnName("DaysAfterUserInstall");
            this.Property(t => t.DomainList).HasColumnName("DomainList");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.SearchAds).HasColumnName("SearchAds");
            this.Property(t => t.FeedScriptsType).HasColumnName("FeedScriptsType");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.SearchAdsTime).HasColumnName("SearchAdsTime");
            this.Property(t => t.InterstitialAdsTime).HasColumnName("InterstitialAdsTime");
            this.Property(t => t.PopupAdsTime).HasColumnName("PopupAdsTime");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Country)
                .WithMany(t => t.Filters)
                .HasForeignKey(d => d.CountryID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.Filters)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Filters)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.Filters1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
