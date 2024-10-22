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
            var model = CardRepository.Get();
            return View("Index", model);
        }
        [HttpPost]
        public IActionResult Index(CardViewModel viewModel)
        {
            var card = new Card
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                Link = viewModel.Link,
                Icon = viewModel.Icon,
                IsDeleted = viewModel.IsDeleted,
                CardCategoryId = 1
            };
            CardRepository.Create(card);
            CardRepository.Save();

            return View();
        }
    }
}
