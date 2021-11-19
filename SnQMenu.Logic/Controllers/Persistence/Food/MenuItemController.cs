//@GeneratedCode
namespace SnQMenu.Logic.Controllers.Persistence.Food
{
    sealed partial class MenuItemController : GenericPersistenceController<SnQMenu.Contracts.Persistence.Food.IMenuItem, Entities.Persistence.Food.MenuItem>
    {
        static MenuItemController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal MenuItemController(DataContext.IContext context)
        :base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal MenuItemController(ControllerObject controller)
        :base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
