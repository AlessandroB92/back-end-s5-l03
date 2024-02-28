using back_end_s5_l03.Models;
using Microsoft.AspNetCore.Mvc;

namespace back_end_s5_l03.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            var articles = ArticleDatabase.GetAllArticles();
            return View(articles);
        }
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var article = ArticleDatabase.GetArticleById(id);
            if (article == null)
            {
                return NotFound(); // Restituisce 404 se l'articolo non è trovato
            }
            return View("~/Views/Home/Details.cshtml", article);
        }

        // Implementare le altre azioni CRUD
    }
}
