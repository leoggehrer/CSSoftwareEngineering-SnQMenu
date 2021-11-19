//@GeneratedCode
namespace SnQMenu.WebApi.Controllers.Persistence.Food
{
    using Microsoft.AspNetCore.Mvc;
    using TContract = Contracts.Persistence.Food.IMenu;
    using TModel = Transfer.Models.Persistence.Food.Menu;
    [ApiController]
    [Route("Controller")]
    public partial class MenusController : WebApi.Controllers.GenericController<TContract, TModel>
    {
    }
}
