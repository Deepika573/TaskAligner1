using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class IssueManager : IIssueManager
    {
        private readonly IIssueRepository _issueRepository;

        public IssueManager(IIssueRepository issueRepository)
        {
            _issueRepository = issueRepository;
        }

        public Task<IEnumerable<Issue>> GetAllIssueAsync()
        {
            return _issueRepository.GetAllIssueAsync();
        }

        public Task<Issue> AddIssueAsync(Issue issue)
        {
            return _issueRepository.AddAsync(issue);
        }

        public Task<Issue> UpdateIssueAsync(int id, Issue issue)
        {
            return _issueRepository.UpdateAsync(id, issue);

        }
        public Task<Issue> DeleteIssueAsync(int id)
        {
            return _issueRepository.DeleteAsync(id);
        }
    }
}
