using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Stud.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }

}
