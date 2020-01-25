using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsonModelValidtion.Models
{
    public class Login
    {
        [Required (ErrorMessage ="username is required")]
        [DisplayName("UserName")]
        public string Uname { get; set; }
        [Required (ErrorMessage ="Password is requried")]
        [DisplayName("Password")]
        public string Pawd { get; set; }
    }
}
