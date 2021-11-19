//@GeneratedCode
namespace SnQMenu.Logic.Controllers.Persistence.MasterData
{
    sealed partial class RestaurantController : GenericPersistenceController<SnQMenu.Contracts.Persistence.MasterData.IRestaurant, Entities.Persistence.MasterData.Restaurant>
    {
        static RestaurantController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal RestaurantController(DataContext.IContext context)
        :base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal RestaurantController(ControllerObject controller)
        :base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
