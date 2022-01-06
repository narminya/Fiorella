using Fiorella.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewModel
{
    public class SubscribeViewModel
    {
        public ContactSection ContactSection { get; set; }
        public Subscriber subscriber { get; set; }
    }
}
