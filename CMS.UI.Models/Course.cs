namespace CMS.UI.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        public Course(int courseId, string? courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }
}