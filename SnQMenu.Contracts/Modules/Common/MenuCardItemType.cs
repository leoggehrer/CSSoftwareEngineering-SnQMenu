namespace SnQMenu.Contracts.Modules.Common
{
    public enum MenuCardItemType
    {
        RestaurantData = 1,
        MenuData = 2,
        AvailableLanguage = 4,
        MenuSection = 8,
        MenuItem = 16,
        ContentType = RestaurantData + MenuSection + MenuItem,
    }
}
