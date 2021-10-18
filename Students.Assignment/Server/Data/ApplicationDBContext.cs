using Microsoft.EntityFrameworkCore;
using Students.Assignment.Shared.Courses;
using Students.Assignment.Shared.Models;

namespace Blazor.Learner.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
