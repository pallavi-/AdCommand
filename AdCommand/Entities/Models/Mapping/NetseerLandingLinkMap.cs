using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class NetseerLandingLinkMap : EntityTypeConfiguration<NetseerLandingLink>
    {
        public NetseerLandingLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Link)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("NetseerLandingLink");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Link).HasColumnName("Link");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.NetseerLandingLinks)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.NetseerLandingLinks1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
