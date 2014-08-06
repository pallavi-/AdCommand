using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class FilterDistributorMap : EntityTypeConfiguration<FilterDistributor>
    {
        public FilterDistributorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FilterDistributor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FilterID).HasColumnName("FilterID");
            this.Property(t => t.DistributorCodeID).HasColumnName("DistributorCodeID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.DistributorCode)
                .WithMany(t => t.FilterDistributors)
                .HasForeignKey(d => d.DistributorCodeID);
            this.HasRequired(t => t.Filter)
                .WithMany(t => t.FilterDistributors)
                .HasForeignKey(d => d.FilterID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.FilterDistributors)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.FilterDistributors1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
