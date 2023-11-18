using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace elshaday_test_api.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder) {
            builder.Property(x => x.Street).IsRequired();
            builder.Property(x => x.Neighborhood).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.PostalCode).IsRequired();
            builder.Property(x => x.PersonId).IsRequired();
            builder.HasOne(x => x.Person);
        }
    }
}
