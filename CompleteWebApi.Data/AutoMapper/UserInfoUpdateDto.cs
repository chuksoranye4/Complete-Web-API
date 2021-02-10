using System.ComponentModel.DataAnnotations;

namespace CompleteWebApi.Data.AutoMapper
{
    public class UserInfoCreateUpdateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is require")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
