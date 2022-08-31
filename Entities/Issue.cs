using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class Issue
    {
        [Key]
        public int IssueId { get; set; } //pk 
        [Required]
        public int CategoryId { get; set; } //fk to issuetype 
        [Required]
        public string IssueDescription { get; set; }
        [Required]
        public int Urgency { get; set; } //{1,2,3,4,5}
        [Required]
        public int TaskId { get; set; } //fk reference to task
    }
}
