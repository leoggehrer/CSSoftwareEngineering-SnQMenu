using Microsoft.AspNetCore.Mvc;
using SnQMenu.AspMvc.Models.Modules.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TContract = SnQMenu.Contracts.Business.Food.IMenuCard;
using TModel = SnQMenu.AspMvc.Models.Business.Food.MenuCard;

namespace SnQMenu.AspMvc.Controllers.Business.Food
{
    partial class MenuCardsController
    {
        [HttpGet]
        [ActionName("Index")]
        public override async Task<IActionResult> IndexAsync()
        {
            var guid = HttpContext.Request.Query["guid"].ToString();
            var models = default(IEnumerable<TModel>);

            try
            {
                var predicate = $"Guid == \"{guid}\"";
                using var ctrl = CreateController();
                var entities = await ctrl.QueryAllAsync(predicate).ConfigureAwait(false);

                models = entities.Select(e => ToModel(e));
                models = BeforeView(models, ActionMode.Index);
                models = await BeforeViewAsync(models, ActionMode.Index).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                LastViewError = ex.GetError();
            }
            return View("Index", models);
        }

        [HttpGet]
        [ActionName("IndexById")]
        public virtual async Task<IActionResult> IndexAsync(string guid)
        {
            var models = default(IEnumerable<TModel>);

            try
            {
                var predicate = $"Guid == \"{guid}\"";
                using var ctrl = CreateController();
                var entities = await ctrl.QueryAllAsync(predicate).ConfigureAwait(false);

                models = entities.Select(e => ToModel(e));
                models = BeforeView(models, ActionMode.Index);
                models = await BeforeViewAsync(models, ActionMode.Index).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                LastViewError = ex.GetError();
            }
            return View("Index", models);
        }
    }
}
