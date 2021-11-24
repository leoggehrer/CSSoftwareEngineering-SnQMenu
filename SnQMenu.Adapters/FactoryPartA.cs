//@GeneratedCode
namespace SnQMenu.Adapters
{
    public static partial class Factory
    {
        public static Contracts.Client.IAdapterAccess<C> Create<C>()
        {
            Contracts.Client.IAdapterAccess<C> result = null;
            if (Adapter == AdapterType.Controller)
            {
                if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.MasterData.IRestaurant>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Food.IMenu>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Food.IMenuItem>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Food.IMenuSection>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IAccess>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IActionLog>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IIdentity>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IIdentityXRole>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.ILoginSession>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IRole>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IUser>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantMenues>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Food.IMenuCard>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Food.IMenuMenuSections>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Account.IAppAccess>() as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Account.IIdentityUser>() as Contracts.Client.IAdapterAccess<C>;
                }
            }
            else if (Adapter == AdapterType.Service)
            {
                if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage, Transfer.Models.Persistence.MasterData.AvailableLanguage>(BaseUri, "AvailableLanguages")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.MasterData.IRestaurant, Transfer.Models.Persistence.MasterData.Restaurant>(BaseUri, "Restaurants")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Food.IMenu, Transfer.Models.Persistence.Food.Menu>(BaseUri, "Menus")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Food.IMenuItem, Transfer.Models.Persistence.Food.MenuItem>(BaseUri, "MenuItems")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Food.IMenuSection, Transfer.Models.Persistence.Food.MenuSection>(BaseUri, "MenuSections")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IAccess, Transfer.Models.Persistence.Account.Access>(BaseUri, "Accesses")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IActionLog, Transfer.Models.Persistence.Account.ActionLog>(BaseUri, "ActionLogs")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IIdentity, Transfer.Models.Persistence.Account.Identity>(BaseUri, "Identities")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IIdentityXRole, Transfer.Models.Persistence.Account.IdentityXRole>(BaseUri, "IdentityXRoles")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.ILoginSession, Transfer.Models.Persistence.Account.LoginSession>(BaseUri, "LoginSessions")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IRole, Transfer.Models.Persistence.Account.Role>(BaseUri, "Roles")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IUser, Transfer.Models.Persistence.Account.User>(BaseUri, "Users")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages, Transfer.Models.Business.MasterData.RestaurantLanguages>(BaseUri, "RestaurantLanguages")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantMenues, Transfer.Models.Business.MasterData.RestaurantMenues>(BaseUri, "RestaurantMenues")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Food.IMenuCard, Transfer.Models.Business.Food.MenuCard>(BaseUri, "MenuCards")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Food.IMenuMenuSections, Transfer.Models.Business.Food.MenuMenuSections>(BaseUri, "MenuMenuSections")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems, Transfer.Models.Business.Food.MenuSectionMenuItems>(BaseUri, "MenuSectionMenuItems")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Account.IAppAccess, Transfer.Models.Business.Account.AppAccess>(BaseUri, "AppAccesses")
                    as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Account.IIdentityUser, Transfer.Models.Business.Account.IdentityUser>(BaseUri, "IdentityUsers")
                    as Contracts.Client.IAdapterAccess<C>;
                }
            }
            return result;
        }
#if ACCOUNT_ON
        public static Contracts.Client.IAdapterAccess<C> Create<C>(string sessionToken)
        {
            Contracts.Client.IAdapterAccess<C> result = null;
            if (Adapter == AdapterType.Controller)
            {
                if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.MasterData.IRestaurant>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Food.IMenu>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Food.IMenuItem>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Food.IMenuSection>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IAccess>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IActionLog>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IIdentity>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IIdentityXRole>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.ILoginSession>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IRole>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Persistence.Account.IUser>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantMenues>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Food.IMenuCard>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Food.IMenuMenuSections>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Account.IAppAccess>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
                {
                    result = new Controller.GenericControllerAdapter<SnQMenu.Contracts.Business.Account.IIdentityUser>(sessionToken) as Contracts.Client.IAdapterAccess<C>;
                }
            }
            else if (Adapter == AdapterType.Service)
            {
                if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage, Transfer.Models.Persistence.MasterData.AvailableLanguage>(sessionToken, BaseUri, "AvailableLanguages") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.MasterData.IRestaurant, Transfer.Models.Persistence.MasterData.Restaurant>(sessionToken, BaseUri, "Restaurants") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Food.IMenu, Transfer.Models.Persistence.Food.Menu>(sessionToken, BaseUri, "Menus") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Food.IMenuItem, Transfer.Models.Persistence.Food.MenuItem>(sessionToken, BaseUri, "MenuItems") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Food.IMenuSection, Transfer.Models.Persistence.Food.MenuSection>(sessionToken, BaseUri, "MenuSections") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IAccess, Transfer.Models.Persistence.Account.Access>(sessionToken, BaseUri, "Accesses") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IActionLog, Transfer.Models.Persistence.Account.ActionLog>(sessionToken, BaseUri, "ActionLogs") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IIdentity, Transfer.Models.Persistence.Account.Identity>(sessionToken, BaseUri, "Identities") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IIdentityXRole, Transfer.Models.Persistence.Account.IdentityXRole>(sessionToken, BaseUri, "IdentityXRoles") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.ILoginSession, Transfer.Models.Persistence.Account.LoginSession>(sessionToken, BaseUri, "LoginSessions") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IRole, Transfer.Models.Persistence.Account.Role>(sessionToken, BaseUri, "Roles") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Persistence.Account.IUser, Transfer.Models.Persistence.Account.User>(sessionToken, BaseUri, "Users") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages, Transfer.Models.Business.MasterData.RestaurantLanguages>(sessionToken, BaseUri, "RestaurantLanguages") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.MasterData.IRestaurantMenues, Transfer.Models.Business.MasterData.RestaurantMenues>(sessionToken, BaseUri, "RestaurantMenues") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Food.IMenuCard, Transfer.Models.Business.Food.MenuCard>(sessionToken, BaseUri, "MenuCards") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Food.IMenuMenuSections, Transfer.Models.Business.Food.MenuMenuSections>(sessionToken, BaseUri, "MenuMenuSections") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems, Transfer.Models.Business.Food.MenuSectionMenuItems>(sessionToken, BaseUri, "MenuSectionMenuItems") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Account.IAppAccess, Transfer.Models.Business.Account.AppAccess>(sessionToken, BaseUri, "AppAccesses") as Contracts.Client.IAdapterAccess<C>;
                }
                else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
                {
                    result = new Service.GenericServiceAdapter<SnQMenu.Contracts.Business.Account.IIdentityUser, Transfer.Models.Business.Account.IdentityUser>(sessionToken, BaseUri, "IdentityUsers") as Contracts.Client.IAdapterAccess<C>;
                }
            }
            return result;
        }
#endif
    }
}
