using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace elshaday_test_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
