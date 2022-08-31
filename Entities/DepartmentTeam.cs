using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class DepartmentTeam
    {
        [Key]
        public int DepTeamId { get; set; }
        [Required]
        public string DepTeamName { get; set; }
        [Required]
        public string RmId { get; set; } //fk to EmployeeId reference to User Table
        [Required]
        public string EmployeeId{ get; set; } //fk to EmployeeId reference to User Table
        [Required]
        public int DepartmentId { get; set; } //fk to Department reference to DepartmentId

    }
}
