using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace elshaday_test_api.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasOne(d => d.Person);
                // .WithMany(p => p.Departments);
                // .HasForeignKey<Department>(d => d.PersonId);
           // builder.Property(d => d.PersonName)
        }
    }
}
