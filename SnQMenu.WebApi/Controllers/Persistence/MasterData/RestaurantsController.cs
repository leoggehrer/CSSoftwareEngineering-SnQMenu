//@GeneratedCode
namespace SnQMenu.WebApi.Controllers.Persistence.MasterData
{
    using Microsoft.AspNetCore.Mvc;
    using TContract = Contracts.Persistence.MasterData.IRestaurant;
    using TModel = Transfer.Models.Persistence.MasterData.Restaurant;
    [ApiController]
    [Route("Controller")]
    public partial class RestaurantsController : WebApi.Controllers.GenericController<TContract, TModel>
    {
    }
}
