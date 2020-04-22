using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class RegistrationModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Your FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter Your LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Your DOB")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Enter Your Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter Your Mail ID")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your must provide a Mobile Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Mobile number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Enter Your Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Enter Your State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter Your City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter Your Address")]
        public string Address { get; set; }
    }
}
