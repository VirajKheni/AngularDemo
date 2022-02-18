using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDemo.Models
{
    [Table("Departments")]
    public class Department
    {
        [Display(Name = "Department ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Display(Name = "Name Of Department")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters.")]
        public string DepartmentName { get; set; }

    }
}
