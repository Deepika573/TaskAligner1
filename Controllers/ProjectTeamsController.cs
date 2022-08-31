using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectTeamsController : ControllerBase
    {
        private readonly IProjectTeamManager _projectTeamManager;

        public ProjectTeamsController(IProjectTeamManager projectTeamManager)
        {
            _projectTeamManager = projectTeamManager;
        }

        [HttpGet]
        public Task<IEnumerable<ProjectTeam>> GetAllProTeamAsync()
        {
            return _projectTeamManager.GetAllProTeamAsync();
        }

        [HttpPost]
        public Task<ProjectTeam> AddProjectTeamAsync([FromBody] ProjectTeam projectTeam)
        {
            return _projectTeamManager.AddProjectTeamAsync(projectTeam);
        }

        [HttpPut("{id:int}")]
        public Task<ProjectTeam> UpdateProjectTeamAsync(int id, [FromBody] ProjectTeam projectTeam)
        {
            return _projectTeamManager.UpdateProjectTeamAsync(id, projectTeam);

        }

        [HttpDelete("{id:int}")]
        public Task<ProjectTeam> DeleteProjectTeamAsync(int id)
        {
            return _projectTeamManager.DeleteProjectTeamAsync(id);
        }
    }
}
