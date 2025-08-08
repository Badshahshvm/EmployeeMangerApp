using System.ComponentModel
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Employee Code")]
        [Required]
        public string Code { get; set; }

        [DisplayName("Date Od Birth ")]
        [Required]
        public DateOnly DOB { get; set; }

        [DisplayName("City")]
        [Required]
        public string City { get; set; }

        [DisplayName("Gender")]
        [Required]
        public string Gender { get; set; }

        [DisplayName("Status")]
        [Required]
        public string Status { get; set; }

    }
}
