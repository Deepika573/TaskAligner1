using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class TasksManager: ITasksManager
    {
        private readonly ITasksRepository _taskRepository;

        public TasksManager(ITasksRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }


        public Task<IEnumerable<Tasks>> GetAllTasksAsync()
        {
            return _taskRepository.GetAllTaskAsync();
        }

        public Task<Tasks> AddTasksAsync(Tasks task)
        {
            return _taskRepository.AddAsync(task);
        }

        public Task<Tasks> UpdateTasksAsync(int id, Tasks task)
        {
            return _taskRepository.UpdateAsync(id, task);

        }

        public Task<Tasks> DeleteTasksAsync(int id)
        {
            return _taskRepository.DeleteAsync(id);
        }
    }
}
