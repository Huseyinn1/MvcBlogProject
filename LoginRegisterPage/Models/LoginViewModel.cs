﻿using System.ComponentModel.DataAnnotations;

namespace LoginRegisterPage.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Username can be min 6 characters")]
        [MaxLength(16, ErrorMessage = "Username can be max 16 characters")]
        public string Password { get; set; }   
    }
}
