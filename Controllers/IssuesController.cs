using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;

namespace TaskAligner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IIssueManager _issueManager;

        public IssuesController(IIssueManager issueManager)
        {
            _issueManager = issueManager;
        }

        [HttpGet]
        public Task<IEnumerable<Issue>> GetAllIssueAsync()
        {
            return _issueManager.GetAllIssueAsync();
        }

        [HttpPost]
        public Task<Issue> AddIssueAsync([FromBody] Issue issue)
        {
            return _issueManager.AddIssueAsync(issue);
        }

        [HttpPut("{id:int}")]
        public Task<Issue> UpdateIssueAsync(int id, [FromBody] Issue issue)
        {
            return _issueManager.UpdateIssueAsync(id, issue);

        }

        [HttpDelete("{id:int}")]
        public Task<Issue> DeleteIssueAsync(int id)
        {
            return _issueManager.DeleteIssueAsync(id);
        }
    }
}
