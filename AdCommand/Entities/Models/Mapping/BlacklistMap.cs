using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class BlacklistMap : EntityTypeConfiguration<Blacklist>
    {
        public BlacklistMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Blacklist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.Blacklist1).HasColumnName("Blacklist");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.Blacklists)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Blacklists)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.Blacklists1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
