using MasterCard.Model;
using MasterCard.Service;
using MasterCard.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MasterCard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICardRepository CardRepository;
        public HomeController(ICardRepository cardRepository)
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

            IEnumerable<CardViewModel> model = CardRepository.GetAll().Select(s => new CardViewModel
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
