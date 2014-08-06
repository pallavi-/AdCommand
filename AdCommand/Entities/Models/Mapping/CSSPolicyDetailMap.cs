using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class CSSPolicyDetailMap : EntityTypeConfiguration<CSSPolicyDetail>
    {
        public CSSPolicyDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CSSValue)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CSSPolicyDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CSSPolicyMasterID).HasColumnName("CSSPolicyMasterID");
            this.Property(t => t.CSSMasterID).HasColumnName("CSSMasterID");
            this.Property(t => t.CSSValue).HasColumnName("CSSValue");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.CSSMaster)
                .WithMany(t => t.CSSPolicyDetails)
                .HasForeignKey(d => d.CSSMasterID);
            this.HasRequired(t => t.CSSPolicyMaster)
                .WithMany(t => t.CSSPolicyDetails)
                .HasForeignKey(d => d.CSSPolicyMasterID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.CSSPolicyDetails)
                .HasForeignKey(d => d.ModifiedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.CSSPolicyDetails1)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
