using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testDatabaseCore.Models.Core;

namespace testDatabaseCore.DAL.DBConfiguration.Core
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company", "Cor");

            builder.Property(c => c.CompanyTitle)
                .IsRequired().HasMaxLength(200);

            builder.Property(c => c.EconomicalNumber).HasMaxLength(20);

            builder.Property(c => c.RegistrationNumber).HasMaxLength(200);

            builder.Property(c => c.Email).HasMaxLength(150);

            builder.Property(c => c.Description).HasMaxLength(150);

            builder.Property(c => c.BranchCode);

            builder.HasOne(tk => tk.Parent).WithMany(t => t.Children).HasForeignKey(tk => tk.ParentId);
        }
    }
}
