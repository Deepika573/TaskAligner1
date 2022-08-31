using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; } //PK and fk to issue
        [Required]
        public string TaskName { get; set; }
        [Required]
        public string  TaskDescription { get; set; }
        [Required]
        public string AssignedToId { get; set; }//Fk to EmployeeId reference to User
        [Required]
        public int ProjectId { get; set; }// Fk to ProjectId reference from Project
        [Required]
        public DateTime TaskDeadLine { get; set; }
        
    }
}
