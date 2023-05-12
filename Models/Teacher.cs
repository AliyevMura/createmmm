namespace WebTaskLayout.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Student = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Student> Student { get; set; }
    }
}
