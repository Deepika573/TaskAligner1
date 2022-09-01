using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public TasksRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<Tasks>> GetAllTaskAsync()
        {
            return await _taskAlignerDbContext.Tasks.ToListAsync();

        }
        public async Task<Tasks> AddAsync(Tasks task)
        {

            await _taskAlignerDbContext.AddAsync(task);
            await _taskAlignerDbContext.SaveChangesAsync();
            return task;
        }

        public async Task<Tasks> UpdateAsync(int id, Tasks task)
        {
            var existing_project = await _taskAlignerDbContext.Tasks.AsNoTracking().FirstOrDefaultAsync(x => x.TaskId == id);
            if (existing_project == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            task.TaskId = existing_project.TaskId;
            _taskAlignerDbContext.Update(task);
            await _taskAlignerDbContext.SaveChangesAsync();
            return task;

        }

        public async Task<Tasks> DeleteAsync(int id)
        {
            var task = await _taskAlignerDbContext.Tasks.FirstOrDefaultAsync(x => x.TaskId == id);
            if (task == null)
            {
                return null;
            }
            //else delete the project//
            _taskAlignerDbContext.Tasks.Remove(task);
            await _taskAlignerDbContext.SaveChangesAsync();
            return task;

        }
    }
}
