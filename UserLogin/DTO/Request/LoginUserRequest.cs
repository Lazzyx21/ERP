﻿using System.ComponentModel.DataAnnotations;

namespace UserLogin.DTO.Request
{
    public class LoginUserRequest
    {
        [EmailAddress]
        [RegularExpression("[^@\\t\\r\\n] + @ \\t\\r\\n].[^@ \\t\\r\\n] + ", ErrorMessage = "Your Email is not valid")]

        public string Email { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%&*-]).{8,}$", ErrorMessage = "Your Password was not set")]
        [MinLength(8), MaxLength(100)]

        public string Password { get; set; }
    }
}
