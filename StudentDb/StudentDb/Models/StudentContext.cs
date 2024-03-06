using System.Data.Entity;

namespace StudentDb.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(): base() 
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
