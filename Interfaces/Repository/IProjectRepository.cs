using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllProjectAsync();
        Task<Project> AddAsync(Project project);
        Task<Project> UpdateAsync(int id, Project project);
        Task<Project> DeleteAsync(int id);

    }
}

