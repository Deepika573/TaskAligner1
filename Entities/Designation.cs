using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; } //Pk and fk to user
        [Required]
        public string DesignationName { get; set; }
    }
}
