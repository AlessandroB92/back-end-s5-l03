using back_end_s5_l03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace back_end_s5_l03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Recupera gli articoli da visualizzare sulla home page
            var articlesToShow = ArticleDatabase.GetAllArticles().Where(a => a.IsDisplayedOnHomePage).ToList();
            return View(articlesToShow);
        }
        public IActionResult Admin()
        {
            // Recupera gli articoli da visualizzare sulla home page
            var articlesToShow = ArticleDatabase.GetAllArticles().Where(a => a.IsDisplayedOnHomePage).ToList();
            return View(articlesToShow);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
