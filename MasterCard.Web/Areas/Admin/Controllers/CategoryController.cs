using MasterCard.Service;
using Microsoft.AspNetCore.Mvc;

namespace MasterCard.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryRepository;
        public CategoryController(CategoryService categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }
        public IActionResult Index()
        {
            return View(_categoryRepository.Get());
        }
    }
}
