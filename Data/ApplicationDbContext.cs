using azure_app_wale.Models;
using Microsoft.EntityFrameworkCore;

namespace azure_app_wale.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
