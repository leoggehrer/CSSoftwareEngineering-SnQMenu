//@GeneratedCode
namespace SnQMenu.AspMvc.Controllers.Persistence.Food
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TContract = Contracts.Persistence.Food.IMenuItem;
    using TModel = AspMvc.Models.Persistence.Food.MenuItem;
    public partial class MenuItemsController : AspMvc.Controllers.GenericController<TContract, TModel>
    {
        static MenuItemsController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public MenuItemsController()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
    }
}
