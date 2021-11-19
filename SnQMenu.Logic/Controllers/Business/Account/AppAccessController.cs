//@GeneratedCode
namespace SnQMenu.Logic.Controllers.Business.Account
{
    [Logic.Modules.Security.Authorize("SysAdmin", "AppAdmin")]
    sealed partial class AppAccessController : GenericOneToManyController<SnQMenu.Contracts.Business.Account.IAppAccess, Entities.Business.Account.AppAccess, SnQMenu.Contracts.Persistence.Account.IIdentity, SnQMenu.Logic.Entities.Persistence.Account.Identity, SnQMenu.Contracts.Persistence.Account.IRole, SnQMenu.Logic.Entities.Persistence.Account.Role>
    {
        static AppAccessController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public AppAccessController(DataContext.IContext context)
        :base(context)
        {
            Constructing();
            oneEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.IdentityController(this);
            manyEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.RoleController(this);
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public AppAccessController(ControllerObject controller)
        :base(controller)
        {
            Constructing();
            oneEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.IdentityController(this);
            manyEntityController = new SnQMenu.Logic.Controllers.Persistence.Account.RoleController(this);
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
        private SnQMenu.Logic.Controllers.Persistence.Account.RoleController manyEntityController = null;
        protected override GenericController<SnQMenu.Contracts.Persistence.Account.IRole, SnQMenu.Logic.Entities.Persistence.Account.Role> ManyEntityController
        {
            get => manyEntityController;
            set => manyEntityController = value as SnQMenu.Logic.Controllers.Persistence.Account.RoleController;
        }
    }
}
