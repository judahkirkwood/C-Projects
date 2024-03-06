namespace StudentDb.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
