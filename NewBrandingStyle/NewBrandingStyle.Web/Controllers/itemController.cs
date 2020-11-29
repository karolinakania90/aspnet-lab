using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private ExchangesDbContext dbContext;

        public ItemController(ExchangesDbContext exchangesDbContext) {
            this.dbContext = exchangesDbContext;
        }

        [HttpPost("new")]
        public AddNewItemResponse Post(ItemModel model)
        {

            var itemEntity = new ItemEntity() {
                Description = model.Description,
                IsVisible = model.IsVisible,
                Name = model.Name
            };

            dbContext.Add(itemEntity);
            dbContext.SaveChanges();

            return new AddNewItemResponse()
            {
                Success = !string.IsNullOrEmpty(model.Name) && !string.IsNullOrEmpty(model.Description)
            };
        }

        [HttpGet("saved")]
        public JsonResult Saved() {
            return new JsonResult(dbContext.ItemEntities);
        }
    }
}
