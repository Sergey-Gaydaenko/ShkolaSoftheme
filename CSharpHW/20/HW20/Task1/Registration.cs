using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Registration
    {
        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Data for first name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Data for last name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"((?:0[1-9])|(?:1[0-2]))\/((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/(\d{4})",
            ErrorMessage = "invalid data for bDay")]
        public string BirthDay { get; set; }

        [Required]
        [RegularExpression(@"^male|female$", ErrorMessage = "Gender should be `Male` or `Female`")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(
            @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
            ErrorMessage = "not correct email")]
        public string Email { get; set; }


        [Required]
        [StringLength(12)]
        [MinLength(12)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid data for Phon number")]
        public string PhoneNumber { get; set; }


        [StringLength(2000)]
        public string AdditionalInfo { get; set; }
    }
}