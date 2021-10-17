using Microsoft.EntityFrameworkCore;

namespace Blazor.Learner.Shared.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace DoSo.Students.Shared.Model
    {
        [Index(nameof(IDNumber), IsUnique = true)]
        public class Student
        {
            public int Id { get; set; }
            
            [Required(ErrorMessage = "This field is required")]
            [MaxLength(11, ErrorMessage = "ID Number cannot exceed 11 characters")]
            public string IDNumber { get; set; }

            [Required(ErrorMessage = "This field is required")]
            [MaxLength(100, ErrorMessage = "First name cannot exceed 100 characters")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "This field is required")]
            [MaxLength(100, ErrorMessage = "Last name cannot exceed 100 characters")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "This field is required")]
            [MinimumAgeAttribute]
            public DateTime DateOfBirth { get; set; }
            
            [Required(ErrorMessage = "This field is required")]
            public GenderEnum Gender { get; set; }
            public enum GenderEnum
            {
                Female = 0,
                Male = 1
            }

        }
    }
}
