using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class DistributorCodeAssetScriptMap : EntityTypeConfiguration<DistributorCodeAssetScript>
    {
        public DistributorCodeAssetScriptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DistributorCodeAssetScript");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DistributorCodeID).HasColumnName("DistributorCodeID");
            this.Property(t => t.AssetScriptID).HasColumnName("AssetScriptID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.AssetScript)
                .WithMany(t => t.DistributorCodeAssetScripts)
                .HasForeignKey(d => d.AssetScriptID);
            this.HasRequired(t => t.DistributorCode)
                .WithMany(t => t.DistributorCodeAssetScripts)
                .HasForeignKey(d => d.DistributorCodeID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.DistributorCodeAssetScripts)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.DistributorCodeAssetScripts1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
