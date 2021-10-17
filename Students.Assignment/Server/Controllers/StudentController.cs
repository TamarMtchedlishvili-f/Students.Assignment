using System.Threading.Tasks;
using Blazor.Learner.Server.Data;
using Blazor.Learner.Shared.Models.DoSo.Students.Shared.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Learner.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public StudentController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // return Ok(new[] { new Student { Email = "tamara", Experience = 2.3m, Id = 123 } });

            var devs = await _context.Students.ToListAsync();
            return Ok(devs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(a=>a.Id ==id);
            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Student developer)
        {
            _context.Add(developer);
            await _context.SaveChangesAsync();
            return Ok(developer.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Student developer)
        {
            _context.Entry(developer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = new Student { Id = id };
            _context.Remove(student);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}