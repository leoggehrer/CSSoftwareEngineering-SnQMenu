//@GeneratedCode
namespace SnQMenu.WebApi.Controllers.Persistence.Food
{
    using Microsoft.AspNetCore.Mvc;
    using TContract = Contracts.Persistence.Food.IMenuItem;
    using TModel = Transfer.Models.Persistence.Food.MenuItem;
    [ApiController]
    [Route("Controller")]
    public partial class MenuItemsController : WebApi.Controllers.GenericController<TContract, TModel>
    {
    }
}
