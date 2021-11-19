//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.Food
{
    partial class MenuSection
    {
        public System.Collections.Generic.ICollection<SnQMenu.Logic.Entities.Persistence.Food.MenuItem> MenuItems
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("MenuId")]
        public SnQMenu.Logic.Entities.Persistence.Food.Menu Menu
        {
            get;
            set;
        }
    }
}
