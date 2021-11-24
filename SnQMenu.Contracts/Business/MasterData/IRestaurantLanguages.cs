
namespace SnQMenu.Contracts.Business.MasterData
{
    public interface IRestaurantLanguages : IOneToMany<Persistence.MasterData.IRestaurant, Persistence.MasterData.IAvailableLanguage>, ICopyable<IRestaurantLanguages>
    {
    }
}
