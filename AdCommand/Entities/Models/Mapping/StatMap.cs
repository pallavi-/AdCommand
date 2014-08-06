using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class StatMap : EntityTypeConfiguration<Stat>
    {
        public StatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Installs, t.Searches, t.Browse, t.Uninstalls, t.Active, t.CreatedBy, t.Created, t.ModifiedBy, t.Modified });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Installs)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Searches)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Browse)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Uninstalls)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Active)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreatedBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModifiedBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Stats");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Installs).HasColumnName("Installs");
            this.Property(t => t.Searches).HasColumnName("Searches");
            this.Property(t => t.Browse).HasColumnName("Browse");
            this.Property(t => t.Uninstalls).HasColumnName("Uninstalls");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Day).HasColumnName("Day");
            this.Property(t => t.Hour).HasColumnName("Hour");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.Stats)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.Stats1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
