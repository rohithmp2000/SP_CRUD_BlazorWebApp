using System.ComponentModel.DataAnnotations;

namespace SP_CRUD.Data
{
    public class EmpModel
    {
        [Key]
        public int emp_id { get; set; }

        [Required]
        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Employee Name cannot have less than 5 characters and more than 20 characters in length")]
        public string? emp_name { get; set; }

        [Required]
        //[StringLength(50, MinimumLength = 2, ErrorMessage = "Please mention the designaation")]
        public string? emp_designation { get; set; }

        [Required]
        public int? emp_salary { get; set; }

    }
}
