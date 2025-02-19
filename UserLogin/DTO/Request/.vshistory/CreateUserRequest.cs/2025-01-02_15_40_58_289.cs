using System.ComponentModel.DataAnnotations;

namespace UserLogin.DTO.Request
{
    public class CreateUserRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [Compare(nameof(Password))]

        public string ConfirmPassword { get; set; }
        [Required]

        public string Policy { get; set; }


    }
}
