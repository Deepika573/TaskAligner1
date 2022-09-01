using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IDesignationManager
    {
        Task<IEnumerable<Designation>> GetDesignationAsync();
        Task<Designation> AddAsync(Designation designation);
        Task<Designation> UpdateAsync(int id, Designation designation);
        Task<Designation> DeleteAsync(int id);
    }
}
