using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class InterstitialScriptMap : EntityTypeConfiguration<InterstitialScript>
    {
        public InterstitialScriptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("InterstitialScript");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Style).HasColumnName("Style");
            this.Property(t => t.Html).HasColumnName("Html");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.Timeout).HasColumnName("Timeout");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.InterstitialLandingSiteID).HasColumnName("InterstitialLandingSiteID");
            this.Property(t => t.TriggerType).HasColumnName("TriggerType");
            this.Property(t => t.ProductID).HasColumnName("ProductID");

            // Relationships
            this.HasOptional(t => t.InterstitialLandingSite)
                .WithMany(t => t.InterstitialScripts)
                .HasForeignKey(d => d.InterstitialLandingSiteID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.InterstitialScripts)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.InterstitialScripts)
                .HasForeignKey(d => d.ModifiedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.InterstitialScripts1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
