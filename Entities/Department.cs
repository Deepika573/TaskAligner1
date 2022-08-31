using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }//pk and fk to user
        [Required]
        public string DepartmentName { get; set; }
    }
}
