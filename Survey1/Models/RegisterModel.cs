using System.ComponentModel.DataAnnotations;

namespace Survey1.Models
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }


    }
}
