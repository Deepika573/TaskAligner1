using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentTeamsController
    {
        private readonly IDepartmentTeamManager _departmentTeamManager;

        public DepartmentTeamsController(IDepartmentTeamManager departmentTeamManager)
        {
            _departmentTeamManager = departmentTeamManager;
        }

        [HttpGet]
        public Task<IEnumerable<DepartmentTeam>> GetAllDeptAsync()
        {
            return _departmentTeamManager.GetAllDepartmentTeamsAsync();
        }

        [HttpPost]
        public Task<DepartmentTeam> AddDeptAsync([FromBody] DepartmentTeam departmentTeam)
        {
            return _departmentTeamManager.AddAsync(departmentTeam);
        }

        [HttpPut("{id:int}")]
        public Task<DepartmentTeam> UpdateDeptAsync(int deptTeamid, [FromBody] DepartmentTeam departmentTeam)
        {
            return _departmentTeamManager.UpdateAsync(deptTeamid, departmentTeam);

        }

        [HttpDelete("{id:int}")]
        public Task<DepartmentTeam> DeleteDeptAsync(int deptTeamid)
        {
            return _departmentTeamManager.DeleteAsync(deptTeamid);
        }
    }
}
