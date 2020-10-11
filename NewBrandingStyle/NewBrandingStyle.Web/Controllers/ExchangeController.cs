using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class ExchangeController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
