using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        [HttpPost("new")]
        public AddNewItemResponse Post(ItemModel model)
        {
            return new AddNewItemResponse()
            {
                Success = !string.IsNullOrEmpty(model.Name) && !string.IsNullOrEmpty(model.Description)
            };
        }
    }
}
