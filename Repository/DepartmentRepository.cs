using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class DepartmentRepository :IDepartmentRepository
    {
        private readonly TaskAlignerDbContext  _taskAlignerDbContext;

        public DepartmentRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentAsync()
        {
            return await _taskAlignerDbContext.Department.ToListAsync();

        }
        public async Task<Department> AddAsync(Department department)
        {
            
            await _taskAlignerDbContext.AddAsync(department);
            await _taskAlignerDbContext.SaveChangesAsync();
            return department;
        }

        public async Task<Department> UpdateAsync(int id, Department department)
        {
            var existing_department = await _taskAlignerDbContext.Department.AsNoTracking().FirstOrDefaultAsync(x => x.DepartmentId == id);
            if (existing_department == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            department.DepartmentId=existing_department.DepartmentId;
            _taskAlignerDbContext.Update(department);
            await _taskAlignerDbContext.SaveChangesAsync();
            return department;

        }

        public async Task<Department> DeleteAsync(int id)
        {
            var department = await _taskAlignerDbContext.Department.FirstOrDefaultAsync(x => x.DepartmentId == id);
            if (department == null)
            {
                return null;
            }
            //else delete the region//
            _taskAlignerDbContext.Department.Remove(department);
            await _taskAlignerDbContext.SaveChangesAsync();
            return department;

        }



    }
}
