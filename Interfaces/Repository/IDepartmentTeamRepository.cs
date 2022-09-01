using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Repository
{
    public interface IDepartmentTeamRepository
    {
        Task<IEnumerable<DepartmentTeam>> GetAllDepartmentTeamsAsync();
        Task<DepartmentTeam> AddAsync(DepartmentTeam departmentTeam);
        Task<DepartmentTeam> UpdateAsync(int depTeamid, DepartmentTeam departmentTeam);
        Task<DepartmentTeam> DeleteAsync(int depTeamid);
    }
}