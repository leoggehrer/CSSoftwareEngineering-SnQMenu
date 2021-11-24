//@GeneratedCode
namespace SnQMenu.Logic
{
    public static partial class Factory
    {
        static partial void CreateController<C>(ref Contracts.Client.IControllerAccess<C> controller) where C : Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
            {
                controller = new Controllers.Persistence.MasterData.AvailableLanguageController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
            {
                controller = new Controllers.Persistence.MasterData.RestaurantController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
            {
                controller = new Controllers.Persistence.Food.MenuController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
            {
                controller = new Controllers.Persistence.Food.MenuItemController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
            {
                controller = new Controllers.Persistence.Food.MenuSectionController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
            {
                controller = new Controllers.Persistence.Account.AccessController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
            {
                controller = new Controllers.Persistence.Account.ActionLogController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
            {
                controller = new Controllers.Persistence.Account.IdentityController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
            {
                controller = new Controllers.Persistence.Account.IdentityXRoleController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
            {
                controller = new Controllers.Persistence.Account.LoginSessionController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
            {
                controller = new Controllers.Persistence.Account.RoleController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
            {
                controller = new Controllers.Persistence.Account.UserController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
            {
                controller = new Controllers.Business.MasterData.RestaurantLanguagesController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
            {
                controller = new Controllers.Business.MasterData.RestaurantMenuesController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
            {
                controller = new Controllers.Business.Food.MenuCardController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
            {
                controller = new Controllers.Business.Food.MenuMenuSectionsController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
            {
                controller = new Controllers.Business.Food.MenuSectionMenuItemsController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
            {
                controller = new Controllers.Business.Account.AppAccessController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
            {
                controller = new Controllers.Business.Account.IdentityUserController(CreateContext()) as Contracts.Client.IControllerAccess<C>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
        static partial void CreateController<C>(object sharedController, ref Contracts.Client.IControllerAccess<C> controller) where C : Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
            {
                controller = new Controllers.Persistence.MasterData.AvailableLanguageController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
            {
                controller = new Controllers.Persistence.MasterData.RestaurantController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
            {
                controller = new Controllers.Persistence.Food.MenuController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
            {
                controller = new Controllers.Persistence.Food.MenuItemController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
            {
                controller = new Controllers.Persistence.Food.MenuSectionController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
            {
                controller = new Controllers.Persistence.Account.AccessController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
            {
                controller = new Controllers.Persistence.Account.ActionLogController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
            {
                controller = new Controllers.Persistence.Account.IdentityController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
            {
                controller = new Controllers.Persistence.Account.IdentityXRoleController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
            {
                controller = new Controllers.Persistence.Account.LoginSessionController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
            {
                controller = new Controllers.Persistence.Account.RoleController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
            {
                controller = new Controllers.Persistence.Account.UserController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
            {
                controller = new Controllers.Business.MasterData.RestaurantLanguagesController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
            {
                controller = new Controllers.Business.MasterData.RestaurantMenuesController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
            {
                controller = new Controllers.Business.Food.MenuCardController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
            {
                controller = new Controllers.Business.Food.MenuMenuSectionsController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
            {
                controller = new Controllers.Business.Food.MenuSectionMenuItemsController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
            {
                controller = new Controllers.Business.Account.AppAccessController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
            {
                controller = new Controllers.Business.Account.IdentityUserController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<C>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
#if ACCOUNT_ON
        public static void CreateController<C>(string sessionToken, ref Contracts.Client.IControllerAccess<C> controller) where C : Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
            {
                controller = new Controllers.Persistence.MasterData.AvailableLanguageController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
            {
                controller = new Controllers.Persistence.MasterData.RestaurantController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
            {
                controller = new Controllers.Persistence.Food.MenuController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
            {
                controller = new Controllers.Persistence.Food.MenuItemController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
            {
                controller = new Controllers.Persistence.Food.MenuSectionController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
            {
                controller = new Controllers.Persistence.Account.AccessController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
            {
                controller = new Controllers.Persistence.Account.ActionLogController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
            {
                controller = new Controllers.Persistence.Account.IdentityController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
            {
                controller = new Controllers.Persistence.Account.IdentityXRoleController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
            {
                controller = new Controllers.Persistence.Account.LoginSessionController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
            {
                controller = new Controllers.Persistence.Account.RoleController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
            {
                controller = new Controllers.Persistence.Account.UserController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantLanguages))
            {
                controller = new Controllers.Business.MasterData.RestaurantLanguagesController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.MasterData.IRestaurantMenues))
            {
                controller = new Controllers.Business.MasterData.RestaurantMenuesController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuCard))
            {
                controller = new Controllers.Business.Food.MenuCardController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuMenuSections))
            {
                controller = new Controllers.Business.Food.MenuMenuSectionsController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Food.IMenuSectionMenuItems))
            {
                controller = new Controllers.Business.Food.MenuSectionMenuItemsController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IAppAccess))
            {
                controller = new Controllers.Business.Account.AppAccessController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Business.Account.IIdentityUser))
            {
                controller = new Controllers.Business.Account.IdentityUserController(CreateContext())
                {
                    SessionToken = sessionToken
                }
                as Contracts.Client.IControllerAccess<C>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
#endif
    }
}
