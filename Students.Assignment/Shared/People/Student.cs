using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Students.Assignment.Shared.Courses;
using Students.Assignment.Shared.People;

namespace Students.Assignment.Shared.Models
{
    public class Student : Person
    {
        public DateTime DateOfEnrollment { get; set; }
        public Course Course { get; set; }
    }
}
