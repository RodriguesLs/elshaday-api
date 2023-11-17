using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace elshaday_test_api.Data.Map
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder) {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Street).IsRequired();
            builder.Property(x => x.Neighborhood).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.PostalCode).IsRequired();
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.PersonId).IsRequired();
            builder.HasOne(x => x.Person);
        }
    }
}
