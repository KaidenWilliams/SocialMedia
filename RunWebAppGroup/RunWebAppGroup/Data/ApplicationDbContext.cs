using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RunWebAppGroup.Models;

namespace RunWebAppGroup.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

 
        
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }


    }
}