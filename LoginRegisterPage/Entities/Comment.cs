using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcBlog.Entities
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Metin { get; set; }

        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        // Kullanıcının kimliğini tutacak
        public Guid KullaniciID { get; set; }

        // Yorumun hangi bloga ait olduğunu belirtir
        public int BlogId { get; set; }

        // Bir yorumun bir kullanıcısı vardır
        [ForeignKey("KullaniciID")]
        public virtual User User { get; set; }

        // Bir yorumun bir blogu vardır
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}



