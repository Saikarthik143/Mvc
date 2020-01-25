using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsonModelValidtion.Models
{
    public class Employee
    {
        [Required(ErrorMessage =" Enter id")]
        [DisplayName("Employee id")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter name")]
      
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="Name shouble be in alphabets")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid email id")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid pls enter numbers")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Username is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Paswword is  Required")]
        [RegularExpression("[a-z0-9@!#$]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="not same")]
        public string Cpwd { get; set; }
    
    
    }
}
