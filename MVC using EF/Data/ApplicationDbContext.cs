
using Microsoft.EntityFrameworkCore;
using MVC_using_EF.Models;


namespace MVC_using_EF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
