using Fiorella.Models.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private FiorellaDataContext _dt;

        public BlogViewComponent(FiorellaDataContext dt)
        {
            _dt = dt;
        }

        public IViewComponentResult Invoke()
        {
            return View(_dt.blogs.ToList());
        }
    }
}
