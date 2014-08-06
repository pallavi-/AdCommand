using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class AdPolicyDetailMap : EntityTypeConfiguration<AdPolicyDetail>
    {
        public AdPolicyDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AdPolicyDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AdPolicyMasterID).HasColumnName("AdPolicyMasterID");
            this.Property(t => t.AdProviderID).HasColumnName("AdProviderID");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.AdProvider)
                .WithMany(t => t.AdPolicyDetails)
                .HasForeignKey(d => d.AdProviderID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.AdPolicyDetails)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.AdPolicyDetails1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
