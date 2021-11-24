
namespace SnQMenu.Contracts.Business.MasterData
{
    public interface IRestaurantMenues : IOneToMany<Persistence.MasterData.IRestaurant, Persistence.Food.IMenu>, ICopyable<IRestaurantMenues>
    {
    }
}
