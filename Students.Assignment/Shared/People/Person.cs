using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Students.Assignment.Shared.Models
{
    [Index(nameof(IDNumber), IsUnique = true)]
    public class Person : BaseEntity
    {
        
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
        [MinimumAge]
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