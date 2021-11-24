using SnQMenu.Logic.Entities.Persistence.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQMenu.Logic.Controllers.Persistence.Food
{
    partial class MenuController
    {
        protected override void AfterCreate(Menu entity)
        {
            entity.Guid = Guid.NewGuid().ToString();

            base.AfterCreate(entity);
        }
    }
}
