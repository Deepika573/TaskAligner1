using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IDesignationRepository
    {
        Task<IEnumerable<Designation>> GetDesignationAsync();
        Task<Designation> AddAsync(Designation designation);
        Task<Designation> UpdateAsync(int id, Designation designation);
        Task<Designation> DeleteAsync(int id);
    }
}
