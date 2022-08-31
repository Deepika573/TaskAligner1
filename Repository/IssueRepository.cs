using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class IssueRepository : IIssueRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public IssueRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<Issue>> GetAllIssueAsync()
        {
            return await _taskAlignerDbContext.Issue.ToListAsync();

        }
        public async Task<Issue> AddAsync(Issue issue)
        {

            await _taskAlignerDbContext.AddAsync(issue);
            await _taskAlignerDbContext.SaveChangesAsync();
            return issue;
        }

        public async Task<Issue> UpdateAsync(int id, Issue issue)
        {
            var existing_issue = await _taskAlignerDbContext.Issue.AsNoTracking().FirstOrDefaultAsync(x => x.IssueId == id);
            if (existing_issue == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            issue.IssueId = existing_issue.IssueId;
            _taskAlignerDbContext.Update(issue);
            await _taskAlignerDbContext.SaveChangesAsync();
            return issue;

        }

        public async Task<Issue> DeleteAsync(int id)
        {
            var issue = await _taskAlignerDbContext.Issue.FirstOrDefaultAsync(x => x.IssueId == id);
            if (issue == null)
            {
                return null;
            }
            //else delete the region//
            _taskAlignerDbContext.Issue.Remove(issue);
            await _taskAlignerDbContext.SaveChangesAsync();
            return issue;

        }
    }
}
