using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class PopUpPerDistributorMap : EntityTypeConfiguration<PopUpPerDistributor>
    {
        public PopUpPerDistributorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PopUpPerDistributor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DistributorCodeID).HasColumnName("DistributorCodeID");
            this.Property(t => t.PopUpAdID).HasColumnName("PopUpAdID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.DistributorCode)
                .WithMany(t => t.PopUpPerDistributors)
                .HasForeignKey(d => d.DistributorCodeID);
            this.HasRequired(t => t.PopUpAd)
                .WithMany(t => t.PopUpPerDistributors)
                .HasForeignKey(d => d.PopUpAdID);
            this.HasRequired(t => t.PopUpPerDistributor2)
                .WithOptional(t => t.PopUpPerDistributor1);
            this.HasRequired(t => t.User)
                .WithMany(t => t.PopUpPerDistributors)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.PopUpPerDistributors1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
