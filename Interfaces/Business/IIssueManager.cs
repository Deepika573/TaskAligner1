using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IIssueManager
    {
        Task<IEnumerable<Issue>> GetAllIssueAsync();
        Task<Issue> AddIssueAsync(Issue issue);
        Task<Issue> UpdateIssueAsync(int id, Issue issue);
        Task<Issue> DeleteIssueAsync(int id);
    }
}
