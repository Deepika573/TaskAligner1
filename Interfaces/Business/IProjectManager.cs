using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IProjectManager
    {
        Task<IEnumerable<Project>> GetAllProAsync();
        Task<Project> AddProAsync(Project project);
        Task<Project> UpdateProAsync(int id, Project project);
        Task<Project> DeleteProAsync(int id);
    }
}
