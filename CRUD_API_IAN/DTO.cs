using System.ComponentModel.DataAnnotations;

namespace CRUD_API_IAN.DTOs
{
    public class TeacherCreateDto
    {
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [Required]
        public string MainSubject { get; set; }
        public string TeacherID { get; set; }
        public decimal Salary { get; set; }
    }
}