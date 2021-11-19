//@CodeCopy
//MdStart
using SnQMenu.Contracts.Modules.Common;

namespace SnQMenu.Contracts.ThirdParty
{
    public interface ITranslation : IVersionable, ICopyable<ITranslation>
    {
        string AppName { get; set; }
        LanguageCode KeyLanguage { get; set; }
        string Key { get; set; }
        LanguageCode ValueLanguage { get; set; }
        string Value { get; set; }
    }
}
//MdEnd
