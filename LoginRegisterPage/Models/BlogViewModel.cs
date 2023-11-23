using System;

namespace LoginRegisterPage.Entities
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public Guid UserId { get; set; } // Kullanıcının Guid ID'sini tutacak
    }
}