using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.Entity;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class BasketController : Controller
    {
        private FiorellaDataContext _dt;
        public BasketController(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public async Task<IActionResult> AddToBasket(int id)
        {
            Product product = await _dt.products.FindAsync(id);

            List<BasketViewModel> basket;

            var basketJson = Request.Cookies["basket"];

            if (string.IsNullOrWhiteSpace(basketJson))
            {
                basket = new List<BasketViewModel>();
            }
            else
            {
                basket = JsonConvert.DeserializeObject<List<BasketViewModel>>(basketJson);
            }


            BasketViewModel existing = basket.Find(b => b.Id == product.Id);
            if (existing==null)
            {
                existing = new BasketViewModel();
                existing.Id = product.Id;
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Image = product.Image;
                existing.Desc = product.Desc;
                existing.CategoryId = product.CategoryId;
                basket.Add(existing);
            }
            else
            {
                existing.Count++;
            }

            

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            return RedirectToAction("index", "Home");
        }

        public async Task<IActionResult> GetBasket()
        {
            List<BasketViewModel> basket = JsonConvert.DeserializeObject<List<BasketViewModel>>(Request.Cookies["basket"]);
            List<BasketViewModel> newBasket = new List<BasketViewModel>();
            foreach (var item in basket)
            {
                Product product = await _dt.products.FindAsync(item.Id);
                if (product == null)
                {
                    continue;
                }
                else
                {
                    newBasket.Add(new BasketViewModel
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Image = product.Image,
                        Desc = product.Desc,
                        CategoryId = product.CategoryId
                    });

                }
            }
            var json = JsonConvert.SerializeObject(newBasket);
            Response.Cookies.Append("basket", json);



            return Json(json);
        }
    }
}
