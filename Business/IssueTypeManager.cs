using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class IssueTypeManager : IIssueTypeManager
    {
        private readonly IIssueTypeRepository _issueTypeRepository;

        public IssueTypeManager(IIssueTypeRepository issueTypeRepository)
        {
            _issueTypeRepository = issueTypeRepository;
        }

        public Task<IEnumerable<IssueType>> GetAllIssueTypeAsync()
        {
            return _issueTypeRepository.GetAllIssueTypeAsync();
        }

        public Task<IssueType> AddIssueTypeAsync(IssueType issueType)
        {
            return _issueTypeRepository.AddAsync(issueType);
        }

        public Task<IssueType> UpdateIssueTypeAsync(int id, IssueType issueType)
        {
            return _issueTypeRepository.UpdateAsync(id, issueType);

        }
        public Task<IssueType> DeleteIssueTypeAsync(int id)
        {
            return _issueTypeRepository.DeleteAsync(id);
        }
    }
}