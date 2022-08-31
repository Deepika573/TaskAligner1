using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class ProjectTeamRepository : IProjectTeamRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public ProjectTeamRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<ProjectTeam>> GetAllProjectTeamAsync()
        {
            return await _taskAlignerDbContext.ProjectTeam.ToListAsync();

        }
        public async Task<ProjectTeam> AddAsync(ProjectTeam projectTeam)
        {

            await _taskAlignerDbContext.AddAsync(projectTeam);
            await _taskAlignerDbContext.SaveChangesAsync();
            return projectTeam;
        }

        public async Task<ProjectTeam> UpdateAsync(int id, ProjectTeam projectTeam)
        {
            var existing_projectTeam = await _taskAlignerDbContext.ProjectTeam.AsNoTracking().FirstOrDefaultAsync(x => x.ProjectTeamId == id);
            if (existing_projectTeam == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            projectTeam.ProjectTeamId = existing_projectTeam.ProjectTeamId;
            _taskAlignerDbContext.Update(projectTeam);
            await _taskAlignerDbContext.SaveChangesAsync();
            return projectTeam;

        }

        public async Task<ProjectTeam> DeleteAsync(int id)
        {
            var projectTeam = await _taskAlignerDbContext.ProjectTeam.FirstOrDefaultAsync(x => x.ProjectTeamId == id);
            if (projectTeam == null)
            {
                return null;
            }
            //else delete the project//
            _taskAlignerDbContext.ProjectTeam.Remove(projectTeam);
            await _taskAlignerDbContext.SaveChangesAsync();
            return projectTeam;

        }
    }
}


