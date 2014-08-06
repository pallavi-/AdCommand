using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class MissedKeywordMap : EntityTypeConfiguration<MissedKeyword>
    {
        public MissedKeywordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BrowseURL)
                .IsRequired()
                .HasMaxLength(900);

            this.Property(t => t.UsedKeyword)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MissedKeyword");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrowseURL).HasColumnName("BrowseURL");
            this.Property(t => t.UsedKeyword).HasColumnName("UsedKeyword");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MissedKeywords)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.MissedKeywords)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.MissedKeywords1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
