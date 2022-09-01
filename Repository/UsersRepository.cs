using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class UsersRepository: IUsersRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public UsersRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<IEnumerable<Users>> GetAllUserAsync()
        {
            return await _taskAlignerDbContext.Users.ToListAsync();

        }
        public async Task<Users> AddAsync(Users user)
        {

            await _taskAlignerDbContext.AddAsync(user);
            await _taskAlignerDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<Users> UpdateAsync(string id, Users user)
        {
            var existing_project = await _taskAlignerDbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.EmployeeId==id);
            if (existing_project == null)
            {
                return null;
            }


            //existing_department.DepartmentName=
            user.EmployeeId = existing_project.EmployeeId;
            _taskAlignerDbContext.Update(user);
            await _taskAlignerDbContext.SaveChangesAsync();
            return user;

        }

        public async Task<Users> DeleteAsync(string id)
        {
            var user = await _taskAlignerDbContext.Users.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (user == null)
            {
                return null;
            }
            //else delete the project//
            _taskAlignerDbContext.Users.Remove(user);
            await _taskAlignerDbContext.SaveChangesAsync();
            return user;

        }
    }

}
