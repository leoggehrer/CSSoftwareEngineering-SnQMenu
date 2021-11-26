namespace SnQMenu.Contracts.Modules.Common
{
    public enum MenuCardItemType
    {
        RestaurantData = 1,
        MenuData = 2,
        AvailableLanguage = 4,
        MenuLanguage = 8,
        MenuSection = 16,
        MenuItem = 32,
        ContentType = RestaurantData + MenuSection + MenuItem,
    }
}
