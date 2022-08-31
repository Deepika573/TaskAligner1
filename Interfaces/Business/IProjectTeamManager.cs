using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IProjectTeamManager
    {
        Task<IEnumerable<ProjectTeam>> GetAllProTeamAsync();
        Task<ProjectTeam> AddProjectTeamAsync(ProjectTeam projectTeam);
        Task<ProjectTeam> UpdateProjectTeamAsync(int id, ProjectTeam projectTeam);
        Task<ProjectTeam> DeleteProjectTeamAsync(int id);
    }
}

