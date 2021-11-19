//@GeneratedCode
namespace SnQMenu.Logic.Controllers.Persistence.Food
{
    sealed partial class MenuSectionController : GenericPersistenceController<SnQMenu.Contracts.Persistence.Food.IMenuSection, Entities.Persistence.Food.MenuSection>
    {
        static MenuSectionController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal MenuSectionController(DataContext.IContext context)
        :base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal MenuSectionController(ControllerObject controller)
        :base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
