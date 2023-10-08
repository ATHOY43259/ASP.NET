using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutIntroandForm.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "*Please Enter your name")]
        [StringLength(50,MinimumLength =4, ErrorMessage = "*Name Must be use 4 to 50 charecter")]
        [RegularExpression("^[a-zA-Z _.-]+$", ErrorMessage = "No number or special charecter allowed.")]

        public string Name { get; set; }


        [Required(ErrorMessage ="*Enter UserID")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "*UserID Must be use 4 to 12 charecter")]
        [RegularExpression("^[a-zA-Z0-9_-]+$", ErrorMessage = "No space allowed, no (.) allowed.")]
       

        public string UserID { get; set; }


        [Required(ErrorMessage ="*Enter Password")]
        [StringLength(8, ErrorMessage = "*Password Must be use minimum 8 charecter")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[a-z]{2})(?=.*[\\W\\d]{4}).{8,}$", ErrorMessage = "First 4 must be alphabets of atleast 1 upper and 2 lowercase and next 4 combines number and special characters letters.")]
        public string Password { get; set; }


        [Required(ErrorMessage ="*Enter ID")]
        [StringLength(10, ErrorMessage = "*Your ID Must be like xx-xxxxx-x")]
        [RegularExpression("^\\d{2}-\\d{5}-\\d*$", ErrorMessage ="Please Insert your with only digits like xx-xxxxx-x")]

        public string ID { get; set; }

        [Required(ErrorMessage ="Enter Email address")]
        [RegularExpression("^\\d{2}-\\d{5}-\\d@student\\.aiub\\.edu$", ErrorMessage = "Please Insert your Email like xx-xxxxx-x@student.aiub.edu")]
        public string Email { get; set; }


        [Required(ErrorMessage ="Select Date of birth")]

        
        public string DOB { get; set; }
    }

}