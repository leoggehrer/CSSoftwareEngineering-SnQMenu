using SnQMenu.Contracts.Modules.Common;
using System;

namespace SnQMenu.Contracts.Business.Food
{
    [ContractInfo]
    public interface IMenuCard : IIdentifiable, ICopyable<IMenuCard>
    {
        Guid Guid { get; }
        [ContractPropertyInfo(MaxLength = 256)]
        string ImageUrl { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256, Order = 1_000)]
        string Text { get; set; }
        [ContractPropertyInfo(MaxLength = 1024, Order = 1_000)]
        string SubText { get; set; }
        [ContractPropertyInfo(MaxLength = 30)]
        string AllergenType { get; set; }
        double Price { get; set; }
        int SortOrder { get; set; }
        MenuCardItemType ItemType { get; set; }
        [ContractPropertyInfo()]
        State State { get; set; }
    }
}
