using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class AdPolicyMasterMap : EntityTypeConfiguration<AdPolicyMaster>
    {
        public AdPolicyMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AdPolicyMaster");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DomainScriptID).HasColumnName("DomainScriptID");
            this.Property(t => t.DistributorID).HasColumnName("DistributorID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.AdPolicyMasters)
                .HasForeignKey(d => d.CountryID);
            this.HasRequired(t => t.Distributor)
                .WithMany(t => t.AdPolicyMasters)
                .HasForeignKey(d => d.DistributorID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.AdPolicyMasters)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.DomainScript)
                .WithMany(t => t.AdPolicyMasters)
                .HasForeignKey(d => d.DomainScriptID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.AdPolicyMasters)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.AdPolicyMasters1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
