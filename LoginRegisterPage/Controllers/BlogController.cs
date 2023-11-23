using LoginRegisterPage.Entities;
using LoginRegisterPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LoginRegisterPage.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataBaseContext _dataBaseContext;

        public BlogController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public IActionResult Blogs()
        {
            var blogs = _dataBaseContext.Blogs.ToList();

            return View(blogs);
        }
        public IActionResult Add_BLog()
        {
            return View("AddBlog");
        }
        public IActionResult Blog_Detail(int id)
        {
            var blog = _dataBaseContext.Blogs.FirstOrDefault(b => b.Id == id);

            if (blog == null)
            {
                return NotFound($"Blog with Id {id} not found."); // Blog bulunamazsa 404 hatası döndür
            }
            var user = _dataBaseContext.Users.FirstOrDefault(u => u.Id == blog.UserID);

            if (user == null)
            {
                return NotFound("User not found");
            }

            var username = user.UserName; // Kullanıcının adını alın

            var viewModel = new BlogDetailViewModel
            {
                Blog = blog,
                UserName = username
            };

            return View(blog);
           
        }
        [HttpPost]
        public IActionResult AddBlog(BlogModel model)
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!string.IsNullOrEmpty(userId) && ModelState.IsValid)
            {
                Guid userGuid = Guid.Parse(userId);

                model.UserId = userGuid;
                var blog = new Blog();
               

                blog.Id = model.Id;
                blog.Title = model.Baslik;
                blog.Content = model.Icerik ?? "Varsayılan İçerik"; ;
                blog.UserID = model.UserId; 
                

          
            _dataBaseContext.Blogs.Add(blog);
            _dataBaseContext.SaveChanges();

            return RedirectToAction("Blogs", "Blog");
        }

      
            return View(model);
        }
}





    }
