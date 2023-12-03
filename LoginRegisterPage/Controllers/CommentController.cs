using Microsoft.AspNetCore.Mvc;
using MvcBlog.Entities;
using MvcBlog.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace MvcBlog.Controllers
{
    public class CommentController : Controller
    {
        private readonly DataBaseContext _dataBaseContext;

        public CommentController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        [HttpPost]
        public IActionResult AddComment(CommentViewModel model)
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            
            if (!string.IsNullOrEmpty(userId) && ModelState.IsValid)
            {
                Guid userGuid = Guid.Parse(userId);
                model.UserId = userGuid;
                var comment = new Comment();

                comment.Metin = model.CommenterMessage;
                comment.OlusturulmaTarihi = DateTime.Now;
                comment.BlogId = model.BlogId;
                comment.KullaniciID = model.UserId;
               

                _dataBaseContext.Comments.Add(comment);
                _dataBaseContext.SaveChanges();

                // Yorum eklendikten sonra kullanıcının bulunduğu blog sayfasına yönlendirilecek.
                // Burada HomeController'ın Index action'ını kullanıyorum, gerçek uygulamanıza uygun olanı seçebilirsiniz.
                return RedirectToAction("Blog_Detail", "Blog", new { id = model.BlogId });
            }

            // Eğer ModelState geçerli değilse, hata mesajlarıyla birlikte geri dönün.
            return View(model);
        }
    }
}
