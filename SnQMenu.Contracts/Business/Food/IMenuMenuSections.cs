
namespace SnQMenu.Contracts.Business.Food
{
    public interface IMenuMenuSections : IOneToMany<Persistence.Food.IMenu, Persistence.Food.IMenuSection>, ICopyable<IMenuMenuSections>
    {
    }
}
