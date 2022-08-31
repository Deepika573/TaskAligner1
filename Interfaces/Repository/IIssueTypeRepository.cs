using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IIssueTypeRepository
    {
        Task<IEnumerable<IssueType>> GetAllIssueTypeAsync();
        Task<IssueType> AddAsync(IssueType issueType);
        Task<IssueType> UpdateAsync(int id, IssueType issueType);
        Task<IssueType> DeleteAsync(int id);
    }
}
