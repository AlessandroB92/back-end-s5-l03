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
            var article = ArticleDatabase.GetArticleById(id);
            if (article == null)
            {
                return NotFound(); // Restituisce 404 se l'articolo non è trovato
            }
            return View("Modifica", article); // Passa il prodotto alla vista di modifica
        }
        [HttpPost]
        public IActionResult Modifica(Article model)
        {
            if (ModelState.IsValid)
            {
                ArticleDatabase.UpdateArticle(model); // Aggiorna il prodotto nel database
                return RedirectToAction("Index"); // Reindirizza alla pagina Admin dopo l'aggiornamento
            }
            return View("Modifica", model); // Se il modello non è valido, torna alla vista di modifica con errori di validazione
        }
    }
}
