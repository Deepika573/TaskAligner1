using TaskAligner.Entities;
using TaskAligner.Models;

namespace TaskAligner.Interfaces.Repository
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAllUserAsync();
        Task<Users> AddAsync(Users user);
        Task<Users> UpdateAsync(string id, Users user);
        Task<Users> DeleteAsync(string id);
        public List<FullUsers> GetFullUsers();
        public List<Project> GetAllUserProjects(string UserId);
        public List<Tasks> GetAllUserProjectTask(string UserId, int PId);
    }
}
