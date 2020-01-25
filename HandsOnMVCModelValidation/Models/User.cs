using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HandsOnMVCModelValidation.Models
{
    public class User
    {
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name shouble be in alphabets")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Enter Correct Mail Syntax")]
        public string Email { get; set; }

        public DateTime DOB { get; set; }
        [RegularExpression(@"[6-9]\d{9}" ,ErrorMessage ="plzenter correct mobile num ")]
        public string  Mobieno { get; set; }
        [Required(ErrorMessage ="select ")]
        public string Country { get; set; }
        [Required(ErrorMessage ="plz ente user name")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Not A strong Pwd")]
        [RegularExpression("[a-z0-9!@#]{8,15}")]
        public string Pawd { get; set; }
    }
}
