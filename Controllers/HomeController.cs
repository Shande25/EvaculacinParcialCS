using Microsoft.AspNetCore.Mvc;
using EjemploMVC_MAT.Services;
using EjemploMVC_MAT.Models;

namespace EjemploMVC_MAT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CardService _cardService;

        public HomeController(ILogger<HomeController> logger, CardService cardService)
        {
            _logger = logger;
            _cardService = cardService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var cards = await _cardService.GetCardsAsync();
            int pageSize = 10;
            var pagedCards = cards.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalCards = cards.Count();
            var totalPages = (int)Math.Ceiling((double)totalCards / pageSize);

            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;

            return View(pagedCards);
        }

       public async Task<IActionResult> Details(int id)
{
    var card = await _cardService.GetCardAsync(id);
    if (card == null)
    {
        return NotFound();
    }
    return View(card);
}

    }
}
