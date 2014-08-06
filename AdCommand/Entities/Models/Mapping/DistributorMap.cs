using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class DistributorMap : EntityTypeConfiguration<Distributor>
    {
        public DistributorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WebSite)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Distributor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.WebSite).HasColumnName("WebSite");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.Distributors)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Distributors)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.Distributors1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
