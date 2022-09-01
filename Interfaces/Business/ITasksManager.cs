using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface ITasksManager
    {
        Task<IEnumerable<Tasks>> GetAllTasksAsync();
        Task<Tasks> AddTasksAsync(Tasks task);
        Task<Tasks> UpdateTasksAsync(int id, Tasks task);
        Task<Tasks> DeleteTasksAsync(int id);
    }
}
