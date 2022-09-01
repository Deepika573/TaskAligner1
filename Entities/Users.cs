using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class Users
    {
        [Key]
        public string EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }//sample
        [Required]
        public int DesignationId { get; set; } //fkey referece: Designation table  DesignationId
        [Required]
        public int DepartmentId { get; set; } //fkey referece: Department table  DepartmentId
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Passwords { get; set; }
        [Required]
        public string Email { get; set; }


        

    }
}
