using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentTeamController
    {
        private readonly IDepartmentTeamManager _departmentTeamManager;

        public DepartmentTeamController(IDepartmentTeamManager departmentTeamManager)
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

        [HttpPut("{deptTeamId:int}")]
        public Task<DepartmentTeam> UpdateDeptAsync(int deptTeamId, [FromBody] DepartmentTeam departmentTeam)
        {
            return _departmentTeamManager.UpdateAsync(deptTeamId, departmentTeam);

        }

        [HttpDelete("{deptTeamId:int}")]
        public Task<DepartmentTeam> DeleteDeptAsync(int deptTeamId)
        {
            return _departmentTeamManager.DeleteAsync(deptTeamId);
        }
    }
}