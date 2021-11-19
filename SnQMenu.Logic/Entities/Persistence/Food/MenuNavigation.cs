//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.Food
{
    partial class Menu
    {
        public System.Collections.Generic.ICollection<SnQMenu.Logic.Entities.Persistence.Food.MenuSection> MenuSections
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RestaurantId")]
        public SnQMenu.Logic.Entities.Persistence.MasterData.Restaurant Restaurant
        {
            get;
            set;
        }
    }
}
