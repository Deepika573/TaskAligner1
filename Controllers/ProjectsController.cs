using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectManager _projectManager;

        public ProjectsController(IProjectManager projectManager)
        {
            _projectManager = projectManager;
        }

        [HttpGet]
        public Task<IEnumerable<Project>> GetAllProAsync()
        {
            return _projectManager.GetAllProAsync();
        }

        [HttpPost]
        public Task<Project> AddProAsync([FromBody] Project project)
        {
            return _projectManager.AddProAsync(project);
        }

        [HttpPut("{id:int}")]
        public Task<Project> UpdateProAsync(int id, [FromBody] Project project)
        {
            return _projectManager.UpdateProAsync(id, project);

        }

        [HttpDelete("{id:int}")]
        public Task<Project> DeleteProAsync(int id)
        {
            return _projectManager.DeleteProAsync(id);
        }
    }
}
