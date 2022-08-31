using System.ComponentModel.DataAnnotations;

namespace TaskAligner.Entities
{
    public class IssueType
    {
        [Key]
        public int CategoryId { get; set; }//pk
        [Required]
        public string CategoryName { get; set; }//bug, typo, error etc
    }
}
