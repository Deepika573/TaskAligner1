using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public ProjectRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<Project>> GetAllProjectAsync()
        {
            return await _taskAlignerDbContext.Project.ToListAsync();

        }
        public async Task<Project> AddAsync(Project project)
        {

            await _taskAlignerDbContext.AddAsync(project);
            await _taskAlignerDbContext.SaveChangesAsync();
            return project;
        }

        public async Task<Project> UpdateAsync(int id, Project project)
        {
            var existing_project = await _taskAlignerDbContext.Project.AsNoTracking().FirstOrDefaultAsync(x => x.ProjectId == id);
            if (existing_project == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            project.ProjectId = existing_project.ProjectId;
            _taskAlignerDbContext.Update(project);
            await _taskAlignerDbContext.SaveChangesAsync();
            return project;

        }

        public async Task<Project> DeleteAsync(int id)
        {
            var project = await _taskAlignerDbContext.Project.FirstOrDefaultAsync(x => x.ProjectId == id);
            if (project == null)
            {
                return null;
            }
            //else delete the project//
            _taskAlignerDbContext.Project.Remove(project);
            await _taskAlignerDbContext.SaveChangesAsync();
            return project;

        }
    }
}
