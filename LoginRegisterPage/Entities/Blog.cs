using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBlog.Entities
{
    [Table("blogs")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Kullanıcının kimliğini tutacak
        public Guid UserID { get; set; }

        // Bir blogun bir kullanıcısı vardır
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
