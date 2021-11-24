using SnQMenu.Logic.Entities.Persistence.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQMenu.Logic.Controllers.Persistence.Food
{
    partial class MenuSectionController
    {
        protected override void AfterCreate(MenuSection entity)
        {
            entity.Guid = System.Guid.NewGuid().ToString();

            base.AfterCreate(entity);
        }
    }
}
