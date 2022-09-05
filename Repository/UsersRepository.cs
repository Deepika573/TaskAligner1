using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;
using TaskAligner.Models;

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

        //For getting full user
        public List<FullUsers> GetFullUsers()
        {
            var query = (from user in _taskAlignerDbContext.Users
                         join designation in _taskAlignerDbContext.Designation
                             on user.DesignationId equals designation.DesignationId 
                             join department in _taskAlignerDbContext.Department
                                on user.DepartmentId equals department.DepartmentId
                                 select new FullUsers()
                                 {   EmployeeId = user.EmployeeId,
                                     EmployeeName = user.EmployeeName,
                                     DesignationName = designation.DesignationName,
                                     DepartmentName = department.DepartmentName,
                                     UserName = user.UserName,
                                     Passwords = user.Passwords,
                                     Email = user.Email
                                 }).ToList();
            return query;
        }

        public List<Project> GetAllUserProjects(string UserId)
        {
                var Project = _taskAlignerDbContext.Project.Where(p=> p.AssignedToUserId == UserId).ToList();
                return Project;
        }

        public List<Tasks> GetAllUserProjectTask(string UserId, int PId)
        {
            var Tasks = _taskAlignerDbContext.Tasks.Where(p => p.AssignedToId == UserId && p.ProjectId == PId).ToList();
            return Tasks;
        }
    }

}
