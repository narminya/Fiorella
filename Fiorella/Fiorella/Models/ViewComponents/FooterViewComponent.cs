using Fiorella.Models.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private FiorellaDataContext _dt;
        public FooterViewComponent(FiorellaDataContext dt)
        {
            _dt = dt;
        }
        public IViewComponentResult Invoke()
        {
            return View(_dt.layouts.FirstOrDefault());
        }
    }
}
