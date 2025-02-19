using System.ComponentModel.DataAnnotations;

namespace UserLogin.DTO.Request
{
    public class CreateUserRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [Compare(nameof(Password))]

        public string Password { get; set; }

    }
}
