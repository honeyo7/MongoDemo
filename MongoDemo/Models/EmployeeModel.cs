using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDemo.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string name { get; set; }
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Required]
        public string email { get; set; }
    }
}
