//@CodeCopy
using SnQMenu.Contracts.Client;

namespace SnQMenu.Logic
{
    public static partial class Factory
    {
        internal static DataContext.IContext CreateContext()
        {
            return new DataContext.SnQMenuDbContext();
        }

        public static IControllerAccess<C> Create<C>()
            where C : SnQMenu.Contracts.IIdentifiable
        {
            var result = default(IControllerAccess<C>);

            CreateController(ref result);
            return result;
        }
        public static IControllerAccess<C> Create<C>(object controllerObject)
            where C : SnQMenu.Contracts.IIdentifiable
        {
            var result = default(IControllerAccess<C>);

            CreateController(controllerObject, ref result);
            return result;
        }
#if ACCOUNT_ON
        public static IControllerAccess<C> Create<C>(string sessionToken)
            where C : SnQMenu.Contracts.IIdentifiable
        {
            var result = default(IControllerAccess<C>);

            CreateController(sessionToken, ref result);
            return result;
        }

        public static IAccountManager CreateAccountManager() => new Modules.Account.AccountManagerWrapper();
#endif
        static partial void CreateController<C>(ref IControllerAccess<C> controller)
            where C : SnQMenu.Contracts.IIdentifiable;
        static partial void CreateController<C>(object sharedController, ref IControllerAccess<C> controller)
            where C : SnQMenu.Contracts.IIdentifiable;
    }
}
