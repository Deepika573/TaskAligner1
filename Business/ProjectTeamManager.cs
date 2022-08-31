using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;
using TaskAligner.Entities;


namespace TaskAligner.Business
{
    public class ProjectTeamManager : IProjectTeamManager
    {
        private readonly IProjectTeamRepository _projectTeamRepository;

        public ProjectTeamManager(IProjectTeamRepository projectTeamRepository)
        {
            _projectTeamRepository = projectTeamRepository;
        }


        public Task<IEnumerable<ProjectTeam>> GetAllProTeamAsync()
        {
            return _projectTeamRepository.GetAllProjectTeamAsync();
        }

        public Task<ProjectTeam> AddProjectTeamAsync(ProjectTeam projectTeam)
        {
            return _projectTeamRepository.AddAsync(projectTeam);
        }

        public Task<ProjectTeam> UpdateProjectTeamAsync(int id, ProjectTeam projectTeam)
        {
            return _projectTeamRepository.UpdateAsync(id, projectTeam);

        }

        public Task<ProjectTeam> DeleteProjectTeamAsync(int id)
        {
            return _projectTeamRepository.DeleteAsync(id);
        }
    }
}

