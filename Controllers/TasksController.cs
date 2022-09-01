using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksManager _taskManager;

        public TasksController(ITasksManager taskManager)
        {
            _taskManager = taskManager;
        }

        [HttpGet]
        public Task<IEnumerable<Tasks>> GetAllProTeamAsync()
        {
            return _taskManager.GetAllTasksAsync();
        }

        [HttpPost]
        public Task<Tasks> AddProjectTeamAsync([FromBody] Tasks task)
        {
            return _taskManager.AddTasksAsync(task);
        }

        [HttpPut("{id:int}")]
        public Task<Tasks> UpdateProjectTeamAsync(int id, [FromBody] Tasks task)
        {
            return _taskManager.UpdateTasksAsync(id, task);

        }

        [HttpDelete("{id:int}")]
        public Task<Tasks> DeleteTasksAsync(int id)
        {
            return _taskManager.DeleteTasksAsync(id);
        }
    }
}

