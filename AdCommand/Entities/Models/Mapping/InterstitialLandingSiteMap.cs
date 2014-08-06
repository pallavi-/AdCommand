using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class InterstitialLandingSiteMap : EntityTypeConfiguration<InterstitialLandingSite>
    {
        public InterstitialLandingSiteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DomainURL)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("InterstitialLandingSite");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DomainURL).HasColumnName("DomainURL");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.InterstitialLandingSites)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.InterstitialLandingSites1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
