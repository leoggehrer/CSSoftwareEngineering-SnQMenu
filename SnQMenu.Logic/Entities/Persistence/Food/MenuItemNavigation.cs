//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.Food
{
    partial class MenuItem
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("MenuSectionId")]
        public SnQMenu.Logic.Entities.Persistence.Food.MenuSection MenuSection
        {
            get;
            set;
        }
    }
}
