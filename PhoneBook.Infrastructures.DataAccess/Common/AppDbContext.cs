using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Entities.People;
using PhoneBook.Domain.Entities.Phones;
using PhoneBook.Domain.Entities.Tags;
using PhoneBook.Infrastructures.DataAccess.People;

namespace PhoneBook.Infrastructures.DataAccess.Common
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PersonTag> PersonTags { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfig).Assembly);

            base.OnModelCreating(modelBuilder);

        }
    }
}
