//@GeneratedCode
namespace SnQMenu.Logic.Controllers.Business.Account
{
    sealed partial class IdentityUserController : GenericOneToAnotherController<SnQMenu.Contracts.Business.Account.IIdentityUser, Entities.Business.Account.IdentityUser, SnQMenu.Contracts.Persistence.Account.IIdentity, SnQMenu.Logic.Entities.Persistence.Account.Identity, SnQMenu.Contracts.Persistence.Account.IUser, SnQMenu.Logic.Entities.Persistence.Account.User>
    {
        static IdentityUserController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public IdentityUserController(DataContext.IContext context)
        :base(context)
        {
            Constructing();
            oneEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.IdentityController(this);
            anotherEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.UserController(this);
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public IdentityUserController(ControllerObject controller)
        :base(controller)
        {
            Constructing();
            oneEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.IdentityController(this);
            anotherEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.UserController(this);
            Constructed();
        }
        [Attributes.ControllerManagedField]
        private SnQMenu.Logic.Controllers.Persistence.Account.IdentityController oneEntityController = null;
        protected override GenericController<SnQMenu.Contracts.Persistence.Account.IIdentity, SnQMenu.Logic.Entities.Persistence.Account.Identity> OneEntityController
        {
            get => oneEntityController;
            set => oneEntityController = value as SnQMenu.Logic.Controllers.Persistence.Account.IdentityController;
        }
        [Attributes.ControllerManagedField]
        private SnQMenu.Logic.Controllers.Persistence.Account.UserController anotherEntityController = null;
        protected override GenericController<SnQMenu.Contracts.Persistence.Account.IUser, SnQMenu.Logic.Entities.Persistence.Account.User> AnotherEntityController
        {
            get => anotherEntityController;
            set => anotherEntityController = value as SnQMenu.Logic.Controllers.Persistence.Account.UserController;
        }
    }
}
