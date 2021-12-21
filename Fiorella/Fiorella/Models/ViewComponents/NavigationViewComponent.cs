using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewComponents
{
    public class NavigationViewComponent : ViewComponent
    {
        private FiorellaDataContext _dt;

        public NavigationViewComponent(FiorellaDataContext dt)
        {
            _dt = dt;
        }

        public IViewComponentResult Invoke()
        {
            List<BasketViewModel> basket;

            var basketJson = Request.Cookies["basket"];

            if (!string.IsNullOrWhiteSpace(basketJson))
            {
                basket = JsonConvert.DeserializeObject<List<BasketViewModel>>(basketJson);
                int count = basket.Sum(s => s.Count);
               

                TempData["Count"] = count;
            }
            else
            {
                TempData["Count"] = 0;
            }

            return View();
        }
    }
}
