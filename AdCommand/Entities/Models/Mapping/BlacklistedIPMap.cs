using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class BlacklistedIPMap : EntityTypeConfiguration<BlacklistedIP>
    {
        public BlacklistedIPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("BlacklistedIP");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.BlacklistedIPs)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.BlacklistedIPs)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.BlacklistedIPs1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
