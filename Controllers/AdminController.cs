using back_end_s5_l03.Models;
using Microsoft.AspNetCore.Mvc;

namespace back_end_s5_l03.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var articlesToShow = ArticleDatabase.GetAllArticles().Where(a => a.IsDisplayedOnHomePage).ToList();
            return View(articlesToShow);
        }
        public IActionResult Modifica(int id)
        {
            // Recupera il prodotto dal database o da un'altra origine dati
            var article = ArticleDatabase.GetArticleById(id);
            if (article == null)
            {
                return NotFound(); // Restituisce 404 se l'articolo non è trovato
            }
            return View(article); // Passa il prodotto alla vista di modifica
        }
    }
}
