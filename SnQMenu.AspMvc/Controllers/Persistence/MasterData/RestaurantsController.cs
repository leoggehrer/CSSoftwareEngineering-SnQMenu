//@GeneratedCode
namespace SnQMenu.AspMvc.Controllers.Persistence.MasterData
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TContract = Contracts.Persistence.MasterData.IRestaurant;
    using TModel = AspMvc.Models.Persistence.MasterData.Restaurant;
    public partial class RestaurantsController : AspMvc.Controllers.GenericController<TContract, TModel>
    {
        static RestaurantsController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public RestaurantsController()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
    }
}
