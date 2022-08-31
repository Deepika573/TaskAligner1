using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DesignationsController
    {
        private readonly IDesignationManager designationManager;
        public DesignationsController(IDesignationManager designationManager)
        {
            this.designationManager = designationManager;
        }

        [HttpGet]
        public Task<IEnumerable<Designation>> GetAllDeptAsync()
        {
            return designationManager.GetDesignationAsync();
        }

        [HttpPost]
        public Task<Designation> AddDesignationAsync([FromBody] Designation designation)
        {
            return designationManager.AddAsync(designation);
        }

        [HttpPut("{id:int}")]
        public Task<Designation> UpdateDesignationAsync(int id, [FromBody] Designation designation)
        {
            return designationManager.UpdateAsync(id, designation);

        }

        [HttpDelete("{id:int}")]
        public Task<Designation> DeleteDesignationAsync(int id)
        {
            return designationManager.DeleteAsync(id);
        }
    }
}
