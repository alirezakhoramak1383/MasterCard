using MasterCard.Service;
using MasterCard.Web.Models;
using MasterCard.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MasterCard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CardService CardRepository;
        public HomeController(CardService cardRepository)
        {
            this.CardRepository = cardRepository;
        }

        public IActionResult Index()
        {

            //IEnumerable<StudentViewModel> model = studentRepository.GetAllStudents().Select(s => new StudentViewModel
            //{
            //    Id = s.Id,
            //    Name = $"{s.FirstName} {s.LastName}",
            //    EnrollmentNo = s.EnrollmentNo,
            //    Email = s.Email
            //});
            //return View("Index", model);

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
