using Students.Assignment.Shared.Models;

namespace Students.Assignment.Shared.Courses
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public CourseTypeEnum CourseType { get; set; }

        public enum CourseTypeEnum
        {
            Major = 0,
            Minor = 1
        }
    }
}