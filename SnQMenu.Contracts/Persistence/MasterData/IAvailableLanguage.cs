using SnQMenu.Contracts.Modules.Common;

namespace SnQMenu.Contracts.Persistence.MasterData
{
    [ContractInfo]
    public interface IAvailableLanguage : IVersionable, ICopyable<IAvailableLanguage>
    {
        [ContractPropertyInfo(HasUniqueIndexWithName = true, IndexName = "UX_RestaurantLanguage", IndexColumnOrder = 1)]
        int RestaurantId { get; set; }
        [ContractPropertyInfo(HasUniqueIndexWithName = true, IndexName = "UX_RestaurantLanguage", IndexColumnOrder = 2, DefaultValue = "Contracts.Modules.Common.LanguageCode.De")]
        LanguageCode LanguageCode { get; set; }
        [ContractPropertyInfo(MaxLength = 64)]
        string Text { get; set; }
    }
}
