using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IProjectTeamRepository
    {

        Task<IEnumerable<ProjectTeam>> GetAllProjectTeamAsync();
        Task<ProjectTeam> AddAsync(ProjectTeam projectTeam);
        Task<ProjectTeam> UpdateAsync(int id, ProjectTeam projectTeam);
        Task<ProjectTeam> DeleteAsync(int id);


    }
}
