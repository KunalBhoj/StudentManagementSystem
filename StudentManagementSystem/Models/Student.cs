using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student : Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter course.")]
        public string Course { get; set; }

    }
}
