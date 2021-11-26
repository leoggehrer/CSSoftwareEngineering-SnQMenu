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
            var sortOrder = 100;
            var result = new List<IMenuCard>();
            var items = await menuController.Set()
                                            .Where(predicate)
                                            .Include(e => e.MenuSections)
                                            .ThenInclude(e => e.MenuItems)
                                            .ToArrayAsync()
                                            .ConfigureAwait(false);

            foreach (var item in items)
            {
                result.AddRange(await LoadMenuDataAsync(item.RestaurantId).ConfigureAwait(false));

                var sectionOrder = 1000;
                var cardItem = await CreateEntityAsync().ConfigureAwait(false);

                cardItem.Guid = item.Guid;
                cardItem.Text = item.LanguageCode.ToString();
                cardItem.SubText = string.Empty;
                cardItem.SortOrder = sortOrder++;
                cardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.MenuLanguage;
                cardItem.State = item.State;
                result.Add(cardItem);

                foreach (var section in item.MenuSections.OrderBy(e => e.SortOrder))
                {
                    var sectionCardItem = await CreateEntityAsync().ConfigureAwait(false);

                    sectionCardItem.Guid = section.Guid;
                    sectionCardItem.ImageUrl = section.ImageUrl;
                    sectionCardItem.Text = section.Name;
                    sectionCardItem.SubText = section.Description;
                    sectionCardItem.SortOrder = sectionOrder + section.SortOrder;
                    sectionCardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.MenuSection;
                    sectionCardItem.State = section.State;
                    result.Add(sectionCardItem);
                    foreach (var menu in section.MenuItems)
                    {
                        var menuItem = await CreateEntityAsync().ConfigureAwait(false);

                        menuItem.Guid = menu.Guid;
                        menuItem.ImageUrl = menu.ImageUrl;
                        menuItem.Text = menu.Name;
                        menuItem.SubText = menu.Description;
                        menuItem.Price = menu.Price;
                        menuItem.SortOrder = sectionOrder * 10 + section.SortOrder;
                        menuItem.ItemType = Contracts.Modules.Common.MenuCardItemType.MenuItem;
                        menuItem.State = menu.State;
                        result.Add(menuItem);
                    }
                    sectionOrder += 1000;
                }
            }
            return result;
        }
        private async Task<IEnumerable<IMenuCard>> LoadMenuDataAsync(int restaurantId)
        {
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

                cardItem.Guid = item.Guid;
                cardItem.ImageUrl = item.ImageUrl;
                cardItem.Text = item.DisplayName;
                cardItem.SubText = item.WebsiteText;
                cardItem.SortOrder = sortOrder++;
                cardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.RestaurantData;
                cardItem.State = item.State;
                result.Add(cardItem);
                foreach (var language in item.AvailableLanguages)
                {
                    var langCardItem = await CreateEntityAsync().ConfigureAwait(false);

                    langCardItem.Guid = item.Guid;
                    langCardItem.Text = language.LanguageCode.ToString();
                    langCardItem.SubText = language.Text;
                    langCardItem.SortOrder = sortOrder++;
                    langCardItem.ItemType = Contracts.Modules.Common.MenuCardItemType.AvailableLanguage;
                    langCardItem.State = Contracts.Modules.Common.State.Active;
                    result.Add(langCardItem);
                }
            }
            return result;
        }
    }
}
