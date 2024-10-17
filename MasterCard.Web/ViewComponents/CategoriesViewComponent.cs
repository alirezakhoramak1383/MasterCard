using MasterCard.Service;
using MasterCard.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MasterCard.Web.ViewComponents


{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly CategoryService CategoryRepository;
        public CategoriesViewComponent(CategoryService categoryRepository)
        {
            this.CategoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<CategoryViewModel> model = CategoryRepository.Get().Select(s => new CategoryViewModel
            {
                Id = s.Id,
                Title = s.Title,
         
            });
            return View("_CategoryList", model);
        }
    }
}
