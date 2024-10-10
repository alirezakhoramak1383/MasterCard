using MasterCard.Domain.Cards;
using Microsoft.AspNetCore.Mvc;

namespace MasterCard.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCategory(Category command)
        {
            return View();
        }
    }
}
