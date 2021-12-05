using Microsoft.EntityFrameworkCore;
using SnQMenu.Contracts.Business.Food;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace SnQMenu.Logic.Controllers.Business.Food
{
    partial class MenuCardController
    {
        [Attributes.ControllerManagedField]
        private Persistence.Food.MenuController menuController = null;
        [Attributes.ControllerManagedField]
        private Persistence.MasterData.RestaurantController restaurantController = null;

        public override async Task<IEnumerable<IMenuCard>> QueryAllAsync(string predicate)
        {
            var result = new List<IMenuCard>();
            var cardData = await LoadMenuCardAsync(predicate);

            result.AddRange(cardData.OrderBy(e => e.SortOrder));
            return result;
        }

        private async Task<IEnumerable<IMenuCard>> LoadMenuCardAsync(string predicate)
        {
            var count = 0;
            var sortOrder = 100;
            var result = new List<IMenuCard>();
            var items = await menuController.Set()
                                            .Where(predicate)
                                            .Include(e => e.MenuSections)
                                            .ThenInclude(e => e.MenuItems)
                                            .ToArrayAsync()
                                            .ConfigureAwait(false);

            foreach (var item in items.OrderBy(e => e.From))
            {
                result.AddRange(await LoadRestaurantDataAsync(item.RestaurantId).ConfigureAwait(false));

                var cardItem = await CreateEntityAsync().ConfigureAwait(false);
                var currency = result.FirstOrDefault(e => e.ItemType == Contracts.Modules.Common.MenuCardItemType.RestaurantData)?.Currency;

                sortOrder = 100 + (100 * count++);
                cardItem.Guid = item.Guid;
                cardItem.Text = item.LanguageCode.ToString();
                cardItem.SubText = item.LanguageCode.ToString();
                cardItem.SortOrder = sortOrder++;
                cardItem.State = item.State;
                cardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.MenuData;
                result.Add(cardItem);

                foreach (var section in item.MenuSections.OrderBy(e => e.SortOrder))
                {
                    var sectionCardItem = await CreateEntityAsync().ConfigureAwait(false);

                    sectionCardItem.Guid = section.Guid;
                    sectionCardItem.ImageUrl = section.ImageUrl;
                    sectionCardItem.Text = section.Name;
                    sectionCardItem.SubText = section.Description;
                    sectionCardItem.SortOrder = sortOrder++;
                    sectionCardItem.State = section.State;
                    sectionCardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.MenuSection;
                    result.Add(sectionCardItem);
                    foreach (var menu in section.MenuItems.OrderBy(e => e.SortOrder))
                    {
                        var menuItem = await CreateEntityAsync().ConfigureAwait(false);

                        menuItem.Guid = menu.Guid;
                        menuItem.ImageUrl = menu.ImageUrl;
                        menuItem.Text = menu.Name;
                        menuItem.SubText = menu.Description;
                        menuItem.Price = menu.Price;
                        menuItem.Currency = currency;
                        menuItem.SortOrder = sortOrder++;
                        menuItem.State = menu.State;
                        menuItem.ItemType = Contracts.Modules.Common.MenuCardItemType.MenuItem;
                        result.Add(menuItem);
                    }
                }
            }
            return result;
        }
        private async Task<IEnumerable<IMenuCard>> LoadRestaurantDataAsync(int restaurantId)
        {
            var count = 0;
            var sortOrder = 1;
            var result = new List<IMenuCard>();
            var items = await restaurantController.Set()
                                                  .Where(r => r.Id == restaurantId)
                                                  .Include(r => r.AvailableLanguages)
                                                  .ToArrayAsync()
                                                  .ConfigureAwait(false);

            foreach (var item in items)
            {
                var cardItem = await CreateEntityAsync().ConfigureAwait(false);

                sortOrder = 1 + (1000 * count++);
                cardItem.Guid = item.Guid;
                cardItem.ImageUrl = item.ImageUrl;
                cardItem.Text = item.DisplayName;
                cardItem.SubText = item.WebsiteText;
                cardItem.Currency = "EUR";
                cardItem.SortOrder = sortOrder++;
                cardItem.Tag = item.UniqueName;
                cardItem.State = item.State;
                cardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.RestaurantData;
                result.Add(cardItem);
                foreach (var language in item.AvailableLanguages)
                {
                    var langCardItem = await CreateEntityAsync().ConfigureAwait(false);

                    langCardItem.Guid = item.Guid;
                    langCardItem.Text = language.LanguageCode.ToString();
                    langCardItem.SubText = language.Text;
                    langCardItem.SortOrder = sortOrder++;
                    langCardItem.State = Contracts.Modules.Common.State.Active;
                    langCardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.AvailableLanguage;
                    result.Add(langCardItem);
                }
            }
            return result;
        }
    }
}
