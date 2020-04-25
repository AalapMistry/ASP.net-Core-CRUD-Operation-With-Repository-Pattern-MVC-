using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Enter Your FirstName")]
        public string CategoryName { get; set; }
    }
}
