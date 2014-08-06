using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RRM.Entities.Models.Mapping
{
    public class ToolbarEventLogMap : EntityTypeConfiguration<ToolbarEventLog>
    {
        public ToolbarEventLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TraceLevel)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Source)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.HostName)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ToolbarEventLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TraceLevel).HasColumnName("TraceLevel");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.HostName).HasColumnName("HostName");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ToolbarEventLogs)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ToolbarEventLogs)
                .HasForeignKey(d => d.CreatedBy);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.ToolbarEventLogs1)
                .HasForeignKey(d => d.ModifiedBy);

        }
    }
}
