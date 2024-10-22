using MasterCard.Domain.Cards;
using MasterCard.Service;
using MasterCard.Web.Models;
using MasterCard.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MasterCard.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly CardService CardRepository;
        public HomeController(CardService cardRepository)
        {
            this.CardRepository = cardRepository;
        }
        public IActionResult Index()
        {
            var model = CardRepository.Get().Select(s => new CardViewModel
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                Icon = s.Icon,
                Link = s.Link
            });
            return View("Index", model);
        }
        [HttpPost]
        public IActionResult Index(AddCardViewModel viewModel)
        {
            var card = new Card
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                Link = viewModel.Link,
                Icon = viewModel.Icon,
                IsDeleted = viewModel.IsDeleted,
            }; 
            CardRepository.Create(card);
            CardRepository.Save();

            return View();
        }
    }
}
