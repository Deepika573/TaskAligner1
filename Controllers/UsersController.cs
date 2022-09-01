using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]")]
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
    }
}

