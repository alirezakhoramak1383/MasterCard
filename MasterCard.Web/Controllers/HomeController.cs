using MasterCard.Data.Context;
using MasterCard.Service;
using MasterCard.Web.Models;
using MasterCard.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace MasterCard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CardService _cardRepository;
        private readonly MasterCardContext _masterCardContext;

        public HomeController(CardService cardRepository, MasterCardContext masterCardContext)
        {
            _cardRepository = cardRepository;
            _masterCardContext = masterCardContext;
        }

        public IActionResult Index()
        {
            var model = _cardRepository.Get().Select(s => new CardViewModel
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                Icon = s.Icon,
                Link = s.Link
            });
            return View("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
