using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class ProductController : Controller
    {
        private FiorellaDataContext _dt;
        public ProductController(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public IActionResult Index()
        {
            return View(new ProductViewModel { Products = _dt.products.Include(c => c.Category).Take(4).ToList() }); ;
        }

        public PartialViewResult LoadMore(int skipCount)
        {
            var result = _dt.products.Include(c => c.Category).Skip(skipCount).Take(4).ToList();
            return PartialView("_ProductPartial", result);
        }

        public async Task<PartialViewResult> Search(string searched)
        {
            if (string.IsNullOrWhiteSpace(searched))
            {
                return PartialView("_SearchedProductPartial", new List<Product>());
            }

            var products = await _dt.products.Where(p => p.Name.ToLower().Contains(searched.ToLower())).ToListAsync();
       
            return PartialView("_SearchedProductPartial", products);
        }
    }
}
