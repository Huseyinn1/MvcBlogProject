

using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models
{
    public class UserModel
    {

        public Guid Id { get; set; }

        public string? NameSurname { get; set; }

        public string UserName { get; set; }

        public bool Locked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Role { get; set; } = "user";
    }

        public class CreateUserModel
        {
            [Required(ErrorMessage = "Username is required")]
            [StringLength(30, ErrorMessage = "Username can be max 30 characters")]
            public string UserName { get; set; }
            [StringLength(50)]
            public string? NameSurname { get; set; }
            public bool Locked { get; set; }
            [Required(ErrorMessage = "Password is required")]
            [MinLength(6, ErrorMessage = "Password can be min 6 characters")]
            [MaxLength(16, ErrorMessage = "Password can be max 16 characters")]
            public string Password { get; set; }

          
            [Required(ErrorMessage = "RePassword is required")]
            [MinLength(6, ErrorMessage = "RePassword can be min 6 characters")]
            [MaxLength(16, ErrorMessage = "RePassword can be max 16 characters")]
            [Compare(nameof(RePassword))]
            public string RePassword { get; set; }
            [Required]
            [StringLength(50)]
            public string Role { get; set; } = "user";

        }
    public class EditUserModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters")]
        public string UserName { get; set; }
        [StringLength(50)]
        public string? NameSurname { get; set; }
        public bool Locked { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Role { get; set; } = "user";

        public int UserID { get; set; }
    }




}

