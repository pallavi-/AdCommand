using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class PopUpAdMap : EntityTypeConfiguration<PopUpAd>
    {
        public PopUpAdMap()
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
            this.ToTable("PopUpAd");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Trigger).HasColumnName("Trigger");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.PopUpAdLandingSiteID).HasColumnName("PopUpAdLandingSiteID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.Created).HasColumnName("Created");

            // Relationships
            this.HasOptional(t => t.PopUpLandingSite)
                .WithMany(t => t.PopUpAds)
                .HasForeignKey(d => d.PopUpAdLandingSiteID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.PopUpAds)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.PopUpAds1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
