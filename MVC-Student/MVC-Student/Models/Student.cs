using System.ComponentModel.DataAnnotations;

namespace MVC_Student.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [Display(Description ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Description ="First Name")]
        public string FirstName { get; set; }
      
    }
}