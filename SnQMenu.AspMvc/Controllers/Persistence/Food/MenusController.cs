//@GeneratedCode
namespace SnQMenu.AspMvc.Controllers.Persistence.Food
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TContract = Contracts.Persistence.Food.IMenu;
    using TModel = AspMvc.Models.Persistence.Food.Menu;
    public partial class MenusController : AspMvc.Controllers.GenericController<TContract, TModel>
    {
        static MenusController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public MenusController()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
    }
}
