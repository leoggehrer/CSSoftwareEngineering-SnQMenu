
namespace SnQMenu.Contracts.Business.Food
{
    public interface IMenuSectionMenuItems : IOneToMany<Persistence.Food.IMenuSection, Persistence.Food.IMenuItem>, ICopyable<IMenuSectionMenuItems>
    {
    }
}
