using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class DomainScriptRevisionMap : EntityTypeConfiguration<DomainScriptRevision>
    {
        public DomainScriptRevisionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.URLPattern)
                .IsRequired()
                .HasMaxLength(2048);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(4000);

            this.Property(t => t.Version)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DomainScriptRevision");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.URLPattern).HasColumnName("URLPattern");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Html).HasColumnName("Html");
            this.Property(t => t.Style).HasColumnName("Style");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.IsJQuery).HasColumnName("IsJQuery");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.ChangeLog).HasColumnName("ChangeLog");
            this.Property(t => t.RevisionCreated).HasColumnName("RevisionCreated");
            this.Property(t => t.OldDomainScriptID).HasColumnName("OldDomainScriptID");

            // Relationships
            this.HasOptional(t => t.Country)
                .WithMany(t => t.DomainScriptRevisions)
                .HasForeignKey(d => d.CountryID);
            this.HasOptional(t => t.DomainScript)
                .WithMany(t => t.DomainScriptRevisions)
                .HasForeignKey(d => d.OldDomainScriptID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.DomainScriptRevisions)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.DomainScriptRevisions)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.DomainScriptRevisions1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
