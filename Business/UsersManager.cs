using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;
using TaskAligner.Models;

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

        public List<FullUsers> GetFullUsers()
        {
            return _userRepository.GetFullUsers();
        }
        public List<Project> GetAllUserProjects(string UserId)
        {
            return _userRepository.GetAllUserProjects(UserId);
        }

        public List<Tasks> GetAllUserProjectTask(string UserId, int PId)
        {
            return _userRepository.GetAllUserProjectTask(UserId, PId);
        }

        //For getting full user using user id
        public FullUsers GetFullUsers(string UserId)
        {
            foreach(FullUsers User in GetFullUsers())
            {
                if(User.EmployeeId == UserId)
                {
                    return User;
                }
               
            }
            return null;
        }
    }
}
