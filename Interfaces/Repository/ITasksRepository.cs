using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface ITasksRepository
    {
        Task<IEnumerable<Tasks>> GetAllTaskAsync();
        Task<Tasks> AddAsync(Tasks task);
        Task<Tasks> UpdateAsync(int id, Tasks task);
        Task<Tasks> DeleteAsync(int id);
    }
}






