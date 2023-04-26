namespace CMS.UI.Models
{
    public class Student
    {
        public Student(int studentId, string? firstName, string? lastName, int courseId)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            CourseId = courseId;
        }

        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CourseId { get; set; }
    }
}