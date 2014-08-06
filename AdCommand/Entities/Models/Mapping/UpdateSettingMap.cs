using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class UpdateSettingMap : EntityTypeConfiguration<UpdateSetting>
    {
        public UpdateSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UpdateURL)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.CustomUpdater)
                .HasMaxLength(255);

            this.Property(t => t.Version)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("UpdateSettings");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.UpdateURL).HasColumnName("UpdateURL");
            this.Property(t => t.CustomUpdater).HasColumnName("CustomUpdater");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.UpdateSettings)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UpdateSettings)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.UpdateSettings1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
