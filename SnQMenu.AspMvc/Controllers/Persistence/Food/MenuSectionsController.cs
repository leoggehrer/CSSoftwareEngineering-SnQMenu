//@GeneratedCode
namespace SnQMenu.AspMvc.Controllers.Persistence.Food
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TContract = Contracts.Persistence.Food.IMenuSection;
    using TModel = AspMvc.Models.Persistence.Food.MenuSection;
    public partial class MenuSectionsController : AspMvc.Controllers.GenericController<TContract, TModel>
    {
        static MenuSectionsController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public MenuSectionsController()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
    }
}
