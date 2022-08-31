using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IDepartmentManager
    {
        Task<IEnumerable<Department>> GetAllDeptAsync();
        Task<Department> AddDeptAsync(Department department);
        Task<Department> UpdateDeptAsync(int id, Department department);
        Task<Department> DeleteDeptAsync(int id);
    }
}
