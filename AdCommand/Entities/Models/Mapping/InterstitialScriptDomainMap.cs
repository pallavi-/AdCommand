using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class InterstitialScriptDomainMap : EntityTypeConfiguration<InterstitialScriptDomain>
    {
        public InterstitialScriptDomainMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Domain)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InterstitialScriptDomain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Domain).HasColumnName("Domain");
            this.Property(t => t.InterstitialScriptID).HasColumnName("InterstitialScriptID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.InterstitialScript)
                .WithMany(t => t.InterstitialScriptDomains)
                .HasForeignKey(d => d.InterstitialScriptID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.InterstitialScriptDomains)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.InterstitialScriptDomains1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
