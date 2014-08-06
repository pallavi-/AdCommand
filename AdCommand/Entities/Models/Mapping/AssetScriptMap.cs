using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class AssetScriptMap : EntityTypeConfiguration<AssetScript>
    {
        public AssetScriptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            this.Property(t => t.Browser)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AssetScript");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.Browser).HasColumnName("Browser");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Country)
                .WithMany(t => t.AssetScripts)
                .HasForeignKey(d => d.CountryID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.AssetScripts)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.AssetScripts)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.AssetScripts1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
