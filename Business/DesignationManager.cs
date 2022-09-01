using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class DesignationManager : IDesignationManager
    {
        private readonly IDesignationRepository designationRepository;

        public DesignationManager(IDesignationRepository designationRepository)
        {
            this.designationRepository = designationRepository;
        }

        public Task<Designation> AddAsync(Designation designation)
        {
            return designationRepository.AddAsync(designation);
        }

        public Task<Designation> DeleteAsync(int id)
        {
            return designationRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Designation>> GetDesignationAsync()
        {
            return designationRepository.GetDesignationAsync();
        }

        public Task<Designation> UpdateAsync(int id, Designation designation)
        {
            return designationRepository.UpdateAsync(id, designation);
        }
    }
}