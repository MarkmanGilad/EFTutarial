using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace EFTutarial2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        [Required]
        public string Class { get; set; } = null!;
        public int ClassNum { get; set; }
        public DateTime Birtday { get; set; }
        public ICollection<Grade>? Grades { get; set; }

        public string Fullname()
        {
            return Lastname + " " + Firstname;
        }
    }
}
