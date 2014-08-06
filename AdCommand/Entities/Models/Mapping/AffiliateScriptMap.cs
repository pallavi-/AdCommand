using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class AffiliateScriptMap : EntityTypeConfiguration<AffiliateScript>
    {
        public AffiliateScriptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(1024);

            this.Property(t => t.AffiliateID)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AffiliateScript");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.AffiliateID).HasColumnName("AffiliateID");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.AffiliateScripts)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.AffiliateScripts)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.AffiliateScripts1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
