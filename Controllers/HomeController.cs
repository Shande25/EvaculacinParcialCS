using EjemploMVC_MAT.Models;
using EjemploMVC_MAT.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EjemploMVC_MAT.Controllers
{
    public class HomeController : Controller
    {
        private readonly CardService _cardService;

        public HomeController(CardService cardService)
        {
            _cardService = cardService;
        }

        // Página principal con listado de cartas
        public async Task<IActionResult> Index(int page = 1)
        {
            var cards = await _cardService.GetCardsAsync(page);
            return View(cards);
        }

        // Página de detalles de una carta individual
        public async Task<IActionResult> Details(int id)
        {
            var card = await _cardService.GetCardDetailsAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            return View(card);
        }
    }
}
