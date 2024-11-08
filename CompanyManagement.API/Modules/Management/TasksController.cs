using CompanyManagement.API.Domain;
using CompanyManagement.API.Modules.Management.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.API.Modules.Management
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            IEnumerable<Entities.Task> foundTasks = await _context
                .Tasks
                .AsNoTracking()
                .ToListAsync();

            return Ok(foundTasks);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] TaskRequest taskRequest)
        {
            var taskToCreate = taskRequest.Adapt<Entities.Task>();
            taskToCreate.CreatedAt = DateTime.UtcNow;

            await _context.Tasks.AddAsync(taskToCreate);
            await _context.SaveChangesAsync();

            return Ok(taskToCreate);
        }
    }
}
