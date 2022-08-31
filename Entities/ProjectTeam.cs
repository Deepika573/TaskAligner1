using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class ProjectTeam
    {
        [Key]
        public int ProjectTeamId { get; set; }//pk and fk to Project
        [Required]
        public int ProjectId { get; set; }//fk from ProjectId and reference from Project class
        [Required]
        public string ProjectHeadId { get; set; } //fk to EmployeeId from User
        [Required]
        public string ProjectTeamEmpId { get; set; }//fk to EmployeeId from User

    }
}
