using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class UsersManager : IUsersManager
    {
        private readonly IUsersRepository _userRepository;

        public UsersManager(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            return _userRepository.GetAllUserAsync();
        }

        public Task<Users> AddUsersAsync(Users user)
        {
            return _userRepository.AddAsync(user);
        }

        public Task<Users> UpdateUsersAsync(string id, Users user)
        {
            return _userRepository.UpdateAsync(id, user);

        }

        public Task<Users> DeleteUsersAsync(string id)
        {
            return _userRepository.DeleteAsync(id);
        }
    }
}
