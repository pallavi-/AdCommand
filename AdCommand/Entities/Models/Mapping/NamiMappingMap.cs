using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class NamiMappingMap : EntityTypeConfiguration<NamiMapping>
    {
        public NamiMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Auth)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("NamiMapping");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SID).HasColumnName("SID");
            this.Property(t => t.DistributorCodeID).HasColumnName("DistributorCodeID");
            this.Property(t => t.Auth).HasColumnName("Auth");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.DistributorCode)
                .WithMany(t => t.NamiMappings)
                .HasForeignKey(d => d.DistributorCodeID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.NamiMappings)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.NamiMappings1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
