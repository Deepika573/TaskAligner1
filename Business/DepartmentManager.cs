using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public Task<IEnumerable<Department>> GetAllDeptAsync()
        {
            return _departmentRepository.GetAllDepartmentAsync();
        }

        public Task<Department> AddDeptAsync(Department department)
        {
            return _departmentRepository.AddAsync(department);
        }

        public Task<Department> UpdateDeptAsync(int id, Department department)
        {
            return _departmentRepository.UpdateAsync(id, department);

        }

        public Task<Department> DeleteDeptAsync(int id)
        {
            return _departmentRepository.DeleteAsync(id);
        }
    }
}
