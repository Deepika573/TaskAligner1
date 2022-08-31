using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentManager _departmentManager;

        public DepartmentsController(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }

        [HttpGet]
        public Task<IEnumerable<Department>> GetAllDeptAsync()
        {
            return _departmentManager.GetAllDeptAsync();
        }

        [HttpPost]
        public Task<Department> AddDeptAsync([FromBody]Department department)
        {
            return _departmentManager.AddDeptAsync(department);
        }

        [HttpPut("{id:int}")]
        public Task<Department> UpdateDeptAsync(int id, [FromBody] Department department)
        {
            return _departmentManager.UpdateDeptAsync(id, department);

        }

        [HttpDelete("{id:int}")]
        public Task<Department> DeleteDeptAsync(int id)
        {
            return _departmentManager.DeleteDeptAsync(id);
        }
    }
}
