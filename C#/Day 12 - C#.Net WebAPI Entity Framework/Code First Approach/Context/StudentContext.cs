using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;

namespace StudentDetails.Context
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) : base(optionsBuilder)
        {
            
        }*/

        public StudentContext (DbContextOptions<StudentContext> options) : base(options) { }
    }
}
