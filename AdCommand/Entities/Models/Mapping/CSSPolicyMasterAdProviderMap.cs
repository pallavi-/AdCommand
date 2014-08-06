using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class CSSPolicyMasterAdProviderMap : EntityTypeConfiguration<CSSPolicyMasterAdProvider>
    {
        public CSSPolicyMasterAdProviderMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CSSPolicyMasterAdProvider");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CSSPolicyMasterID).HasColumnName("CSSPolicyMasterID");
            this.Property(t => t.AdProviderID).HasColumnName("AdProviderID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.AdProvider)
                .WithMany(t => t.CSSPolicyMasterAdProviders)
                .HasForeignKey(d => d.AdProviderID);
            this.HasRequired(t => t.CSSPolicyMaster)
                .WithMany(t => t.CSSPolicyMasterAdProviders)
                .HasForeignKey(d => d.CSSPolicyMasterID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.CSSPolicyMasterAdProviders)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.CSSPolicyMasterAdProviders1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
