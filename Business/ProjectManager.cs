using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;
using TaskAligner.Entities;


namespace TaskAligner.Business
{
    public class ProjectManager : IProjectManager
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectManager(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }


        public Task<IEnumerable<Project>> GetAllProAsync()
        {
            return _projectRepository.GetAllProjectAsync();
        }

        public Task<Project> AddProAsync(Project project)
        {
            return _projectRepository.AddAsync(project);
        }

        public Task<Project> UpdateProAsync(int id, Project project)
        {
            return _projectRepository.UpdateAsync(id, project);

        }

        public Task<Project> DeleteProAsync(int id)
        {
            return _projectRepository.DeleteAsync(id);
        }
    }
}
