﻿using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password can be min 6 characters")]
        [MaxLength(16, ErrorMessage ="Password can be max 16 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "RePassword is required")]
        [MinLength(6, ErrorMessage = "RePassword can be min 6 characters")]
        [MaxLength(16, ErrorMessage = "RePassword can be max 16 characters")]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
