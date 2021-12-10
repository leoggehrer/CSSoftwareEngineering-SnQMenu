using Microsoft.AspNetCore.Mvc;
using SnQMenu.AspMvc.Models.Modules.Common;
using SnQMenu.AspMvc.Modules.Language;
using SnQMenu.Contracts.Modules.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TModel = SnQMenu.AspMvc.Models.Business.Food.MenuCard;

namespace SnQMenu.AspMvc.Controllers.Business.Food
{
    partial class MenuCardsController
    {
        private void SetSessionData(string guid, string lang, IEnumerable<TModel> models)
        {
            var menuLangugeCode = string.Empty;
            var selectLangugeCode = string.Empty;
            var selectLangugeText = string.Empty;
            var restaurantUniqueName = string.Empty;
            var restaurants = models.Where(e => e.ItemType == MenuCardItemType.RestaurantData).ToArray();
            var menues = models.Where(e => e.ItemType == MenuCardItemType.MenuData).ToArray();
            var languages = models.Where(e => e.ItemType == MenuCardItemType.AvailableLanguage).ToArray();

            if (lang.HasContent())
            {
                var item = languages.FirstOrDefault(e => e.Text == lang);

                if (item != null)
                {
                    selectLangugeCode = item?.Text;
                    selectLangugeText = item?.SubText;
                }
            }
            menuLangugeCode = menues.FirstOrDefault()?.Text;
            if (string.IsNullOrEmpty(selectLangugeCode))
            {
                var menue = menues.FirstOrDefault();

                if (menue != null)
                {
                    var item = languages.FirstOrDefault(e => e.Text == menue.Text);

                    if (item != null)
                    {
                        selectLangugeCode = item?.Text;
                        selectLangugeText = item?.SubText;
                    }
                    else
                    {
                        selectLangugeCode = menue.Text;
                        selectLangugeText = menue.SubText;
                    }
                }
                else
                {
                    var item = languages.FirstOrDefault();

                    selectLangugeCode = item?.Text;
                    selectLangugeText = item?.SubText;
                }
            }
            restaurantUniqueName = restaurants.FirstOrDefault()?.Tag;

            SessionWrapper.SetPageSizes(ControllerName, new int[] { 1000 });
            SessionWrapper.SetStringValue(StaticLiterals.Guid, guid);
            SessionWrapper.SetValue(StaticLiterals.Menues, menues);
            SessionWrapper.SetValue(StaticLiterals.Languages, languages);
            SessionWrapper.SetStringValue(StaticLiterals.MenuLanguageCode, menuLangugeCode);
            SessionWrapper.SetStringValue(StaticLiterals.SelectLanguageCode, selectLangugeCode);
            SessionWrapper.SetStringValue(StaticLiterals.SelectLanguageText, selectLangugeText);
            SessionWrapper.SetStringValue(StaticLiterals.RestaurantUniqueName, restaurantUniqueName);
        }

        [HttpGet]
        [ActionName("Index")]
        public override async Task<IActionResult> IndexAsync()
        {
            var guid = HttpContext.Request.Query["guid"].ToString();
            var models = await LoadMenuCardDataAsync(guid, string.Empty).ConfigureAwait(false);

            return View("Index", models);
        }

        [HttpGet]
        [ActionName("IndexById")]
        public virtual async Task<IActionResult> IndexAsync(string guid)
        {
            var models = await LoadMenuCardDataAsync(guid, string.Empty).ConfigureAwait(false);

            return View("Index", models);
        }

        [HttpGet]
        [ActionName("IndexByIdAndLang")]
        public virtual async Task<IActionResult> IndexAsync(string guid, string lang)
        {
            var models = await LoadMenuCardDataAsync(guid, lang).ConfigureAwait(false);

            return View("Index", models);
        }

        private async Task<IEnumerable<TModel>> LoadMenuCardDataAsync(string guid, string lang)
        {
            var models = default(IEnumerable<TModel>);

            try
            {
                var predicate = $"Guid == \"{guid}\"";
                using var ctrl = CreateController();
                var entities = await ctrl.QueryAllAsync(predicate).ConfigureAwait(false);

                models = entities.Select(e => ToModel(e));
                SetSessionData(guid, lang, models);
                models = BeforeView(models, ActionMode.Index);
                models = await BeforeViewAsync(models, ActionMode.Index).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                LastViewError = ex.GetError();
            }
            return models;
        }
        protected override IEnumerable<TModel> BeforeView(IEnumerable<TModel> models, ActionMode action)
        {
            var result = new List<TModel>();
            var menuLangugeCode = SessionWrapper.GetStringValue(StaticLiterals.MenuLanguageCode, string.Empty);
            var selectLangugeCode = SessionWrapper.GetStringValue(StaticLiterals.SelectLanguageCode, string.Empty);
            var restaurantUniqueName = SessionWrapper.GetStringValue(StaticLiterals.RestaurantUniqueName, string.Empty);

            if (restaurantUniqueName.HasContent() 
                && menuLangugeCode.HasContent()
                && selectLangugeCode.HasContent()
                && menuLangugeCode != selectLangugeCode)
            {
                var menuCode = (LanguageCode)Enum.Parse(typeof(LanguageCode), menuLangugeCode);
                var selectCode = (LanguageCode)Enum.Parse(typeof(LanguageCode), selectLangugeCode);

                Translator.ChangeAppName(restaurantUniqueName);
                Translator.ChangeKeyLanguage(menuCode);
                Translator.ChangeValueLanguage(selectCode);
                Translator.Instance.ReloadTranslations();

                foreach (var item in models)
                {
                    item.Text = Translator.TranslateIt($"{item.Guid}.Text", item.Text);
                    item.SubText = Translator.TranslateIt($"{item.Guid}.SubText", item.SubText);
                    result.Add(item);
                }
            }
            else
            {
                result.AddRange(models);
            }
            return base.BeforeView(result, action);
        }
    }
}
