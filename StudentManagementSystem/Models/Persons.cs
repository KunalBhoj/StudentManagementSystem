using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Enter Your Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter your Age.")]
        [Range(18,70, ErrorMessage = "Age must be between 18 and 70")]
        public int? Age { get; set; }
    }
}
