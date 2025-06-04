using System.Data.Entity;

namespace SPA.Models.Context
{
    public class SPAContext : DbContext
    {
        public DbSet<Person> people { get; set; }
    }
}