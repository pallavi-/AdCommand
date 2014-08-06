using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class NetseerDomainMap : EntityTypeConfiguration<NetseerDomain>
    {
        public NetseerDomainMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Domain)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NetseerDomain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NetseerUnitID).HasColumnName("NetseerUnitID");
            this.Property(t => t.Domain).HasColumnName("Domain");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.NetseerUnit)
                .WithMany(t => t.NetseerDomains)
                .HasForeignKey(d => d.NetseerUnitID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.NetseerDomains)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.NetseerDomains1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
