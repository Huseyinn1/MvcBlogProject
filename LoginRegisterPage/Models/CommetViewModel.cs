namespace MvcBlog.Models
{
  
   public class CommentViewModel
    {
        public string CommenterMessage { get; set; }
        public int BlogId { get; set; }
        public Guid UserId { get; set; }
        // Diğer gerekli alanları ekleyebilirsiniz.
    }
}
