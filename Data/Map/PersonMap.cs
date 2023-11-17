using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace elshaday_test_api.Data.Map
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Document).IsRequired();
            builder.Property(x => x.Nickname);
        }
    }
}
