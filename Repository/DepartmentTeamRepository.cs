using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class DepartmentTeamRepository : IDepartmentTeamRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;
        public DepartmentTeamRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<DepartmentTeam> AddAsync(DepartmentTeam departmentTeam)
        {
            await _taskAlignerDbContext.AddAsync(departmentTeam);
            await _taskAlignerDbContext.SaveChangesAsync();
            return departmentTeam;
        }

        public async Task<DepartmentTeam> DeleteAsync(int depTeamid)
        {
            var deptTeamFromDb = _taskAlignerDbContext.DepartmentTeam.FirstOrDefault(d => d.DepTeamId == depTeamid);
            if (deptTeamFromDb == null)
                return null;
            _taskAlignerDbContext.DepartmentTeam.Remove(deptTeamFromDb);
            await _taskAlignerDbContext.SaveChangesAsync();
            return deptTeamFromDb;
        }

        public async Task<IEnumerable<DepartmentTeam>> GetAllDepartmentTeamsAsync()
        {
            return await _taskAlignerDbContext.DepartmentTeam.ToListAsync();
        }

        public async Task<DepartmentTeam> UpdateAsync(int depTeamid, DepartmentTeam departmentTeam)
        {
            var deptTeamFromDb = _taskAlignerDbContext.DepartmentTeam.AsNoTracking().FirstOrDefault(d => d.DepTeamId == depTeamid);
            if (deptTeamFromDb == null)
                return null;
            departmentTeam.DepTeamId = depTeamid;
            _taskAlignerDbContext.DepartmentTeam.Update(departmentTeam);
            await _taskAlignerDbContext.SaveChangesAsync();
            return departmentTeam;
        }
    }
}
