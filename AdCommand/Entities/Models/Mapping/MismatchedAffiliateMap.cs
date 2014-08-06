using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class MismatchedAffiliateMap : EntityTypeConfiguration<MismatchedAffiliate>
    {
        public MismatchedAffiliateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AffiliateID)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("MismatchedAffiliate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AffiliateID).HasColumnName("AffiliateID");
            this.Property(t => t.OriginalCountryID).HasColumnName("OriginalCountryID");
            this.Property(t => t.NewCountryID).HasColumnName("NewCountryID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.MismatchedAffiliates)
                .HasForeignKey(d => d.NewCountryID);
            this.HasRequired(t => t.Country1)
                .WithMany(t => t.MismatchedAffiliates1)
                .HasForeignKey(d => d.OriginalCountryID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.MismatchedAffiliates)
                .HasForeignKey(d => d.ModifiedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.MismatchedAffiliates1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
