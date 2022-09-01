using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAllUserAsync();
        Task<Users> AddAsync(Users user);
        Task<Users> UpdateAsync(string id, Users user);
        Task<Users> DeleteAsync(string id);
    }
}
