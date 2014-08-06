using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class DefaultScriptPerProductMap : EntityTypeConfiguration<DefaultScriptPerProduct>
    {
        public DefaultScriptPerProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DefaultScriptPerProduct");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DomainScriptID).HasColumnName("DomainScriptID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.DefaultScriptPerProducts)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.DomainScript)
                .WithMany(t => t.DefaultScriptPerProducts)
                .HasForeignKey(d => d.DomainScriptID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.DefaultScriptPerProducts)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.DefaultScriptPerProducts1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
