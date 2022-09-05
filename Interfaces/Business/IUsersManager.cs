using TaskAligner.Entities;
using TaskAligner.Models;

namespace TaskAligner.Interfaces.Business
{
    public interface IUsersManager
    {
        Task<IEnumerable<Users>> GetAllUsersAsync();
        Task<Users> AddUsersAsync(Users user);
        Task<Users> UpdateUsersAsync(string id, Users user);
        Task<Users> DeleteUsersAsync(string id);
        public List<FullUsers> GetFullUsers();
        public List<Project> GetAllUserProjects(string UserId);
        public List<Tasks> GetAllUserProjectTask(string UserId, int PId);
        public FullUsers GetFullUsers(string UserId);

    }
}
