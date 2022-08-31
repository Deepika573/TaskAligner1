using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class IssueTypeRepository : IIssueTypeRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public IssueTypeRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<IssueType>> GetAllIssueTypeAsync()
        {
            return await _taskAlignerDbContext.IssueType.ToListAsync();

        }
        public async Task<IssueType> AddAsync(IssueType issueType)
        {

            await _taskAlignerDbContext.AddAsync(issueType);
            await _taskAlignerDbContext.SaveChangesAsync();
            return issueType;
        }

        public async Task<IssueType> UpdateAsync(int id, IssueType issueType)
        {
            var existing_issueType = await _taskAlignerDbContext.IssueType.AsNoTracking().FirstOrDefaultAsync(x => x.CategoryId == id);
            if (existing_issueType == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            issueType.CategoryId = existing_issueType.CategoryId;
            _taskAlignerDbContext.Update(issueType);
            await _taskAlignerDbContext.SaveChangesAsync();
            return issueType;

        }
        public async Task<IssueType> DeleteAsync(int id)
        {
            var issueType = await _taskAlignerDbContext.IssueType.FirstOrDefaultAsync(x => x.CategoryId == id);
            if (issueType == null)
            {
                return null;
            }
            //else delete the region//
            _taskAlignerDbContext.IssueType.Remove(issueType);
            await _taskAlignerDbContext.SaveChangesAsync();
            return issueType;

        }
    }
}