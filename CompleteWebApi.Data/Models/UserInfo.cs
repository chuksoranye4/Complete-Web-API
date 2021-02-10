using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteWebApi.Data.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="First name is required")]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email is require")]
        [EmailAddress(ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
