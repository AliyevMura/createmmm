namespace WebTaskLayout.Models
{
    public class Group
    {
        public Group()
        {
            Student = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Student { get; set; }
    }
}
