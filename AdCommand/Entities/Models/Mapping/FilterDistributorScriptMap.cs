using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class FilterDistributorScriptMap : EntityTypeConfiguration<FilterDistributorScript>
    {
        public FilterDistributorScriptMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FilterDistributorScript");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DistributorID).HasColumnName("DistributorID");
            this.Property(t => t.DomainScriptID).HasColumnName("DomainScriptID");
            this.Property(t => t.FilterID).HasColumnName("FilterID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Distributor)
                .WithMany(t => t.FilterDistributorScripts)
                .HasForeignKey(d => d.DistributorID);
            this.HasRequired(t => t.DomainScript)
                .WithMany(t => t.FilterDistributorScripts)
                .HasForeignKey(d => d.DomainScriptID);
            this.HasOptional(t => t.Filter)
                .WithMany(t => t.FilterDistributorScripts)
                .HasForeignKey(d => d.FilterID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.FilterDistributorScripts)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.FilterDistributorScripts1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
