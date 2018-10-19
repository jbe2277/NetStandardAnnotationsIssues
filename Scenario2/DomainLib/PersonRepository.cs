using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DomainLib
{
    public static class PersonRepository
    {
        public static void AddPerson(Person person)
        {
            var options = new DbContextOptionsBuilder<PersonContext>().UseInMemoryDatabase("test_db").Options;
            using (var db = new PersonContext(options))
            {
                db.Perons.Add(person);
                db.SaveChanges();
            }
        }
    }

    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        { }

        public DbSet<Person> Perons { get; set; }
    }

    public class Person
    {
        [Required]
        public string Name { get; set; }
    }
}
