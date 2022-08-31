using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IIssueTypeManager
    {
        Task<IEnumerable<IssueType>> GetAllIssueTypeAsync();
        Task<IssueType> AddIssueTypeAsync(IssueType issueType);
        Task<IssueType> UpdateIssueTypeAsync(int id, IssueType issueType);
        Task<IssueType> DeleteIssueTypeAsync(int id);
    }
}
