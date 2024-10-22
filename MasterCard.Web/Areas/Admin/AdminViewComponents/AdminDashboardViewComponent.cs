using MasterCard.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MasterCard.Web.Areas.Admin.AdminViewComponents
{
    public class AdminDashboardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new CardViewModel());
        }

        [HttpPost]
        public IViewComponentResult ProcessForm(CardViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the data (e.g., save to database)
                // ...

                // Optionally redirect or return a different view
                Console.Write(ModelState.ToString());
            }

            // If model is invalid, return the original view with the model to show errors
            return View(model);
        }
    }
}
