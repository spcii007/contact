using Microsoft.EntityFrameworkCore;
using ContactAPI.Models;

namespace ContactAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {}

        public DbSet<Person> Person { set; get; }
        public DbSet<Phone> Phones { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet <Name> Names { get; set; }



    }
}
