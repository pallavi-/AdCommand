using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class ConceptLinkCSSPolicyDetailMap : EntityTypeConfiguration<ConceptLinkCSSPolicyDetail>
    {
        public ConceptLinkCSSPolicyDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.StyleValue)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ConceptLinkCSSPolicyDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ConceptLinkCSSPolicyMasterID).HasColumnName("ConceptLinkCSSPolicyMasterID");
            this.Property(t => t.CSSMasterID).HasColumnName("CSSMasterID");
            this.Property(t => t.StyleValue).HasColumnName("StyleValue");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.ConceptLinkCSSPolicyMaster)
                .WithMany(t => t.ConceptLinkCSSPolicyDetails)
                .HasForeignKey(d => d.ConceptLinkCSSPolicyMasterID);
            this.HasRequired(t => t.CSSMaster)
                .WithMany(t => t.ConceptLinkCSSPolicyDetails)
                .HasForeignKey(d => d.CSSMasterID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ConceptLinkCSSPolicyDetails)
                .HasForeignKey(d => d.ModifiedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.ConceptLinkCSSPolicyDetails1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
