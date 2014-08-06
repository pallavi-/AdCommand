using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class NamiDefaultKeywordMap : EntityTypeConfiguration<NamiDefaultKeyword>
    {
        public NamiDefaultKeywordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Keyword)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NamiDefaultKeyword");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Keyword).HasColumnName("Keyword");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.NamiDefaultKeywords)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.NamiDefaultKeywords1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
