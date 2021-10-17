using Blazor.Learner.Shared.Models.DoSo.Students.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Learner.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        
    }
}
