using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class NetseerUnitMap : EntityTypeConfiguration<NetseerUnit>
    {
        public NetseerUnitMap()
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
            this.ToTable("NetseerUnit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Style).HasColumnName("Style");
            this.Property(t => t.Html).HasColumnName("Html");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.NetseerLandingLinkID).HasColumnName("NetseerLandingLinkID");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ConceptLimit).HasColumnName("ConceptLimit");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.NetseerLandingLink)
                .WithMany(t => t.NetseerUnits)
                .HasForeignKey(d => d.NetseerLandingLinkID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.NetseerUnits)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.NetseerUnits)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.NetseerUnits1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
