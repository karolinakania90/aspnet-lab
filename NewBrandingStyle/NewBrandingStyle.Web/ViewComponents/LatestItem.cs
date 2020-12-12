using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext exchangesDbContext;
        public LatestItem(ExchangesDbContext exchangesDbContext)
        {
            this.exchangesDbContext = exchangesDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = this.exchangesDbContext.ItemEntities.OrderByDescending(c => c.Id).FirstOrDefault();

            return View("Index", latestItem);

        }
    }
}
