using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentAsync();
        Task<Department> AddAsync(Department department);
        Task<Department> UpdateAsync( int id, Department department);
        Task <Department>DeleteAsync(int id);
    }

    
}
