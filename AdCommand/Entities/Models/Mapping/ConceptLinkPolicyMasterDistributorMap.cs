using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class ConceptLinkPolicyMasterDistributorMap : EntityTypeConfiguration<ConceptLinkPolicyMasterDistributor>
    {
        public ConceptLinkPolicyMasterDistributorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ConceptLinkPolicyMasterDistributor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ConceptLinkPolicyMasterID).HasColumnName("ConceptLinkPolicyMasterID");
            this.Property(t => t.DistributorID).HasColumnName("DistributorID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.ConceptLinkPolicyMaster)
                .WithMany(t => t.ConceptLinkPolicyMasterDistributors)
                .HasForeignKey(d => d.ConceptLinkPolicyMasterID);
            this.HasRequired(t => t.Distributor)
                .WithMany(t => t.ConceptLinkPolicyMasterDistributors)
                .HasForeignKey(d => d.DistributorID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ConceptLinkPolicyMasterDistributors)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.ConceptLinkPolicyMasterDistributors1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
