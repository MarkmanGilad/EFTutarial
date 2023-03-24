using EFTutarial2.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFTutarial2.Data
{
    public class StudentsDBContext :DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;

        public StudentsDBContext() { }

        public StudentsDBContext(DbContextOptions<StudentsDBContext> options) : base(options) { }
    }
}
