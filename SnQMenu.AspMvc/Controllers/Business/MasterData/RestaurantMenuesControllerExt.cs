using SnQMenu.AspMvc.Models.Business.MasterData;
using SnQMenu.AspMvc.Models.Modules.Common;
using SnQMenu.AspMvc.Modules.View;
using System.Collections.Generic;

namespace SnQMenu.AspMvc.Controllers.Business.MasterData
{
    using TContract = Contracts.Business.MasterData.IRestaurantMenues;
    using TModel = AspMvc.Models.Business.MasterData.RestaurantMenues;
    partial class RestaurantMenuesController
    {
        protected override TModel BeforeView(TModel model, ActionMode action)
        {
            return base.BeforeView(model, action);
        }
        protected override IEnumerable<RestaurantMenues> BeforeView(IEnumerable<RestaurantMenues> models, ActionMode action)
        {
            //var viewBagWrapper = new ViewBagWrapper(ViewBag);

            //viewBagWrapper.AddIgnoreHidden(nameof(TModel.Guid));
            //viewBagWrapper.AddIgnoreHidden(nameof(TModel.WebsiteText));
            return base.BeforeView(models, action);
        }
    }
}
