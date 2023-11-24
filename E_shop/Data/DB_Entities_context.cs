using E_shop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace E_shop.Data
{
    public class DB_Entities_context : IdentityDbContext
    {
        public DB_Entities_context(DbContextOptions<DB_Entities_context> options):base(options)
        {

        }
       
       // public DbSet<User> Users { get; set; }
    }
}
