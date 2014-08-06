using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class MintCallLimitMap : EntityTypeConfiguration<MintCallLimit>
    {
        public MintCallLimitMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Domain)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MintCallLimit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.DistributorCodeID).HasColumnName("DistributorCodeID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.Domain).HasColumnName("Domain");
            this.Property(t => t.AdProviderID).HasColumnName("AdProviderID");
            this.Property(t => t.Limit).HasColumnName("Limit");
            this.Property(t => t.TimeDiff).HasColumnName("TimeDiff");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.AdProvider)
                .WithMany(t => t.MintCallLimits)
                .HasForeignKey(d => d.AdProviderID);
            this.HasOptional(t => t.Country)
                .WithMany(t => t.MintCallLimits)
                .HasForeignKey(d => d.CountryID);
            this.HasOptional(t => t.DistributorCode)
                .WithMany(t => t.MintCallLimits)
                .HasForeignKey(d => d.DistributorCodeID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MintCallLimits)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.MintCallLimits)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.MintCallLimits1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
