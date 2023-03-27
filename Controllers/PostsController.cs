using ASPNet_Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNet_Blog.Controllers
{
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PostModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            PostModel post = new()
            {
                Id = 1,
                Title = data.Title,
                HeaderImageUrl = data.HeaderImageUrl,
                Body = data.Body,
                CreatedAt = DateTime.Now
            };

            return RedirectToAction("Read", "Posts", new { post.Id });
        }

        public IActionResult Read(int id)
        {
            return View(id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}