//@GeneratedCode
namespace SnQMenu.WebApi.Controllers.Persistence.Food
{
    using Microsoft.AspNetCore.Mvc;
    using TContract = Contracts.Persistence.Food.IMenuSection;
    using TModel = Transfer.Models.Persistence.Food.MenuSection;
    [ApiController]
    [Route("Controller")]
    public partial class MenuSectionsController : WebApi.Controllers.GenericController<TContract, TModel>
    {
    }
}
