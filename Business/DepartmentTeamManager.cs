using TaskAligner.Entities;
using TaskAligner.Interfaces.Business;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Business
{
    public class DepartmentTeamManager : IDepartmentTeamManager
    {
        private readonly IDepartmentTeamRepository _departmentTeamRepository;

        public DepartmentTeamManager(IDepartmentTeamRepository departmentTeamRepository)
        {
            _departmentTeamRepository = departmentTeamRepository;
        }

        public Task<DepartmentTeam> AddAsync(DepartmentTeam departmentTeam)
        {
            return _departmentTeamRepository.AddAsync(departmentTeam);
        }

        public Task<DepartmentTeam> DeleteAsync(int depTeamid)
        {
            return _departmentTeamRepository.DeleteAsync(depTeamid);
        }

        public Task<IEnumerable<DepartmentTeam>> GetAllDepartmentTeamsAsync()
        {
            return _departmentTeamRepository.GetAllDepartmentTeamsAsync();
        }

        public Task<DepartmentTeam> UpdateAsync(int depTeamid, DepartmentTeam departmentTeam)
        {
            return _departmentTeamRepository.UpdateAsync(depTeamid, departmentTeam);
        }
    }
}