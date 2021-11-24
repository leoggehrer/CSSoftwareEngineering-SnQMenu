using SnQMenu.Logic.Entities.Persistence.MasterData;
using System;

namespace SnQMenu.Logic.Controllers.Persistence.MasterData
{
    partial class RestaurantController
    {
        protected override void AfterCreate(Restaurant entity)
        {
            entity.Guid = Guid.NewGuid().ToString();

            base.AfterCreate(entity);
        }
    }
}
