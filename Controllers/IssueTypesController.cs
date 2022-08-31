using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueTypesController : ControllerBase
    {
        private readonly IIssueTypeManager _issueTypeManager;

        public IssueTypesController(IIssueTypeManager issueTypeManager)
        {
            _issueTypeManager = issueTypeManager;
        }

        [HttpGet]
        public Task<IEnumerable<IssueType>> GetAllIssueTypeAsync()
        {
            return _issueTypeManager.GetAllIssueTypeAsync();
        }

        [HttpPost]
        public Task<IssueType> AddIssueTypeAsync([FromBody] IssueType issueType)
        {
            return _issueTypeManager.AddIssueTypeAsync(issueType);
        }

        [HttpPut("{id:int}")]
        public Task<IssueType> UpdateIssueTypeAsync(int id, [FromBody] IssueType issueType)
        {
            return _issueTypeManager.UpdateIssueTypeAsync(id, issueType);

        }

        [HttpDelete("{id:int}")]
        public Task<IssueType> DeleteIssueTypeAsync(int id)
        {
            return _issueTypeManager.DeleteIssueTypeAsync(id);
        }
    }
}
