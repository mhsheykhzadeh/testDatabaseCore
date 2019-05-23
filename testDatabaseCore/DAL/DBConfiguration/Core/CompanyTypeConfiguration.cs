using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testDatabaseCore.Models.Core;

namespace testDatabaseCore.DAL.DBConfiguration.Core
{
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> builder)
        {
            builder.ToTable("CompanyType", "Cor");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
