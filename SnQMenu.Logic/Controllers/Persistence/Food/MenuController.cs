//@GeneratedCode
namespace SnQMenu.Logic.Controllers.Persistence.Food
{
    sealed partial class MenuController : GenericPersistenceController<SnQMenu.Contracts.Persistence.Food.IMenu, Entities.Persistence.Food.Menu>
    {
        static MenuController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal MenuController(DataContext.IContext context)
        :base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal MenuController(ControllerObject controller)
        :base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
