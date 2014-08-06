using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class DistributorCodeMap : EntityTypeConfiguration<DistributorCode>
    {
        public DistributorCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AffiliateID)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DistributorCode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DistributorID).HasColumnName("DistributorID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.AffiliateID).HasColumnName("AffiliateID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Country)
                .WithMany(t => t.DistributorCodes)
                .HasForeignKey(d => d.CountryID);
            this.HasRequired(t => t.Distributor)
                .WithMany(t => t.DistributorCodes)
                .HasForeignKey(d => d.DistributorID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.DistributorCodes)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.DistributorCodes)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.DistributorCodes1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
