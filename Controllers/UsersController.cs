using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Business;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Models;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersManager _userManager;

        public UsersController(IUsersManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            return _userManager.GetAllUsersAsync();
        }

        [HttpPost]
        public Task<Users> AddUsersAsync([FromBody] Users user)
        {
            return _userManager.AddUsersAsync(user);
        }

        [HttpPut("{id}")]
        public Task<Users> UpdateUsersAsync(string id, [FromBody] Users user)
        {
            return _userManager.UpdateUsersAsync(id, user);

        }

        [HttpDelete("{id}")]
        public Task<Users> DeleteUsersAsync(string id)
        {
            return _userManager.DeleteUsersAsync(id);
        }

        //For all the fullusers
        [HttpGet("GetFullUser")]
        public List<FullUsers> GetFullUsers()
        {
            return _userManager.GetFullUsers();
        }

        //Get full user by id
        [HttpGet("GetFullUsers")]
        public ActionResult<FullUsers> GetFullUsers(string user)
        {
            if (_userManager.GetFullUsers(user) == null)
            {
                return StatusCode(404);
            }

            return _userManager.GetFullUsers(user);
        }

        [HttpGet("GetAllUserProjects")]
        public List<Project> GetAllUserProjects(string UserId)
        {
            return _userManager.GetAllUserProjects(UserId);
        }

        [HttpGet("GetAllUserProjectTask")]
        public List<Tasks> GetAllUserProjectTask(string UserId, int PId)
        {
            return _userManager.GetAllUserProjectTask(UserId, PId);
        }


    }
}

