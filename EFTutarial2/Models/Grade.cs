using System.ComponentModel.DataAnnotations;

namespace EFTutarial2.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public int numGrade { get; set; }
        [Required]
        public string? Semester { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public Student? Student { get; set; }
    }
}
