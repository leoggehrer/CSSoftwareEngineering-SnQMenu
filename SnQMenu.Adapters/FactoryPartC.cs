//@GeneratedCode
namespace SnQMenu.Adapters
{
    public static partial class Factory
    {
        public static Contracts.Client.IAdapterAccess<C> CreateThridParty<C>(string baseUri)
        {
            Contracts.Client.IAdapterAccess<C> result = null;
            if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.IHtmlAttribute))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.IHtmlAttribute, Transfer.Models.ThirdParty.HtmlAttribute>(baseUri, "HtmlAttributes")
                as Contracts.Client.IAdapterAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.IHtmlElement))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.IHtmlElement, Transfer.Models.ThirdParty.HtmlElement>(baseUri, "HtmlElements")
                as Contracts.Client.IAdapterAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.IStaticPage))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.IStaticPage, Transfer.Models.ThirdParty.StaticPage>(baseUri, "StaticPages")
                as Contracts.Client.IAdapterAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.ITranslation))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.ITranslation, Transfer.Models.ThirdParty.Translation>(baseUri, "Translations")
                as Contracts.Client.IAdapterAccess<C>;
            }
            return result;
        }
        public static Contracts.Client.IAdapterAccess<C> Create<C>(string baseUri, string sessionToken)
        {
            Contracts.Client.IAdapterAccess<C> result = null;
            if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.IHtmlAttribute))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.IHtmlAttribute, Transfer.Models.ThirdParty.HtmlAttribute>(sessionToken, baseUri, "HtmlAttributes") as Contracts.Client.IAdapterAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.IHtmlElement))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.IHtmlElement, Transfer.Models.ThirdParty.HtmlElement>(sessionToken, baseUri, "HtmlElements") as Contracts.Client.IAdapterAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.IStaticPage))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.IStaticPage, Transfer.Models.ThirdParty.StaticPage>(sessionToken, baseUri, "StaticPages") as Contracts.Client.IAdapterAccess<C>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.ThirdParty.ITranslation))
            {
                result = new Service.GenericServiceAdapter<SnQMenu.Contracts.ThirdParty.ITranslation, Transfer.Models.ThirdParty.Translation>(sessionToken, baseUri, "Translations") as Contracts.Client.IAdapterAccess<C>;
            }
            return result;
        }
    }
}
