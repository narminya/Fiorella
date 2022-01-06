using Fiorella.Models.DataAccessLayer;
using Fiorella.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        private readonly FiorellaDataContext _dt;
        public SubscribeViewComponent(FiorellaDataContext dt)
        {
            _dt = dt;
        }

        public IViewComponentResult Invoke()
        {

            var contactSection =_dt.contactSection.FirstOrDefault();
            return View(new SubscribeViewModel { ContactSection = contactSection });
        }
    }
}
