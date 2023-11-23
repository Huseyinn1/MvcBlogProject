using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegisterPage.Entities
{
    [Table("users")]
    public class User
    {  [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string ?NameSurname{ get; set; }
        
        [Required]
        [StringLength(30)]
        public string UserName{ get; set; }
        
        [Required]
        [StringLength(100)]
        
        public string Password{ get; set; }
        
        public bool Locked{ get; set; } = false;    
        public DateTime CreatedAt{ get; set; } = DateTime.Now;
        [StringLength(255)]
        public string? ProfilImageFileName { get; set; } = "noimage.jpg";
        [Required]
        [StringLength(50)]
        public string Role { get; set; } = "user";
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

    }
}
