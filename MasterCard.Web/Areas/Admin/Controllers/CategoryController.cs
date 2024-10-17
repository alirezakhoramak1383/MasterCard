using MasterCard.Service;
using Microsoft.AspNetCore.Mvc;

namespace MasterCard.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }
        public IActionResult Index()
        {
            return View(_categoryRepository.GetAll());
        }
    }
}
