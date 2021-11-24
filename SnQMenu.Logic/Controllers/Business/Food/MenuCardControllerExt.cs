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
        public override async Task<IEnumerable<IMenuCard>> QueryAllAsync(string predicate)
        {
            var result = new List<IMenuCard>();
            var items = await menuController.Set()
                                            .Where(predicate)
                                            .Include(e => e.MenuSections)
                                            .ThenInclude(e => e.MenuItems)
                                            .ToArrayAsync()
                                            .ConfigureAwait(false);

            return result;
        }
    }
}
