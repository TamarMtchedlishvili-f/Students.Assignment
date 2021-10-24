using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Students.Assignment.Server.Data;
using Students.Assignment.Shared.Courses;

namespace Students.Assignment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses = await _context.Courses.ToListAsync();
            return Ok(courses);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(a=>a.Id ==id);
            return Ok(course);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Course course)
        {
            _context.Add(course);
            await _context.SaveChangesAsync();
            return Ok(course.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var course = new Course { Id = id };
            _context.Remove(course);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}