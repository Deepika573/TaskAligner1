using TaskAligner.Entities;

namespace TaskAligner.Interfaces.Business
{
    public interface IDepartmentTeamManager
    {
        Task<IEnumerable<DepartmentTeam>> GetAllDepartmentTeamsAsync();
        Task<DepartmentTeam> AddAsync(DepartmentTeam departmentTeam);
        Task<DepartmentTeam> UpdateAsync(int depTeamid, DepartmentTeam departmentTeam);
        Task<DepartmentTeam> DeleteAsync(int depTeamid);
    }
}
