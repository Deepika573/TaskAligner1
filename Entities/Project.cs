using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }//pk
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [Required]
        public DateTime ProjectDeadLine { get; set; }
        
        
    }
}
