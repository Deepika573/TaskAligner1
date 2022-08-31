using Microsoft.EntityFrameworkCore;
using TaskAligner.Entities;

namespace TaskAligner.Data
{
    public class TaskAlignerDbContext:DbContext
    {
        public TaskAlignerDbContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<IssueType> IssueType { get; set; }
        public DbSet<Issue> Issue { get; set; }
        public DbSet<DepartmentTeam> DepartmentTeam { get; set; }
        public DbSet<ProjectTeam> ProjectTeam{ get; set; }





    }
}
