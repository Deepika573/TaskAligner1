using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IIssueRepository
    {
        Task<IEnumerable<Issue>> GetAllIssueAsync();
        Task<Issue> AddAsync(Issue issue);
        Task<Issue> UpdateAsync(int id, Issue issue);
        Task<Issue> DeleteAsync(int id);
    }
}
