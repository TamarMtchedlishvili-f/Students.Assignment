using System;
using Microsoft.AspNetCore.Components;
using Students.Assignment.Shared.Courses;

namespace Students.Assignment.Shared.People
{
    public class Student : Person
    {
        public DateTime DateOfEnrollment { get; set; }
        [CascadingParameter]
        public Course Course { get; set; }
    }
}
