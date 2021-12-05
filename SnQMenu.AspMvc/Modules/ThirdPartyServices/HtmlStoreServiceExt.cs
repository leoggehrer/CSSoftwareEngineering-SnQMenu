using CommonBase.Modules.Configuration;
using SnQMenu.AspMvc.Models.ThirdParty;
using SnQMenu.AspMvc.Modules.Handler;
using SnQMenu.Contracts.Modules.Common;
using SnQMenu.Contracts.ThirdParty;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnQMenu.AspMvc.Modules.ThirdPartyServices
{
    partial class HtmlStoreService
    {
        public static IEnumerable<IHtmlAttribute> GetHtmlAttributes(string appName)
        {
            var result = Array.Empty<IHtmlAttribute>() as IEnumerable<IHtmlAttribute>;
            var htmlStoreServer = AppSettings.Configuration[StaticLiterals.EnvironmentHtmlStoreServerKey];

            if (htmlStoreServer.HasContent())
            {
                var ctrl = Adapters.Factory.CreateThridParty<IHtmlAttribute>(htmlStoreServer);
                var predicate = $"{nameof(HtmlAttribute.AppName)} == \"{appName}\" AND {nameof(StaticPage.State)} == \"{State.Active}\"";

                try
                {
                    result = Task.Run(async () =>
                    {
                        return await ctrl.QueryAllAsync(predicate).ConfigureAwait(false);
                    }).Result;
                }
                catch (Exception ex)
                {
                    ErrorHandler.LastLogicError = $"{System.Reflection.MethodBase.GetCurrentMethod().Name}: {ex.GetError()}";
                    System.Diagnostics.Debug.WriteLine(ErrorHandler.LastLogicError);
                }
            }
            return result;
        }
    }
}
