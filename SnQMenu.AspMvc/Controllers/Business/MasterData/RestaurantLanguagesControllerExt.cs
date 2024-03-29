﻿using SnQMenu.AspMvc.Models.Business.MasterData;
using SnQMenu.AspMvc.Models.Modules.Common;
using SnQMenu.AspMvc.Modules.View;
using System.Collections.Generic;

namespace SnQMenu.AspMvc.Controllers.Business.MasterData
{
    using TContract = Contracts.Business.MasterData.IRestaurantLanguages;
    using TModel = AspMvc.Models.Business.MasterData.RestaurantLanguages;

    public partial class RestaurantLanguagesController
    {
        protected override IEnumerable<RestaurantLanguages> BeforeView(IEnumerable<RestaurantLanguages> models, ActionMode action)
        {
            //var viewBagWrapper = new ViewBagWrapper(ViewBag);

            //viewBagWrapper.AddIgnoreHidden(nameof(TModel.Guid));
            //viewBagWrapper.AddIgnoreHidden(nameof(TModel.WebsiteText));

            return base.BeforeView(models, action);
        }
    }
}
