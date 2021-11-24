using SnQMenu.Contracts.Modules.Common;
using System;

namespace SnQMenu.Contracts.Persistence.Food
{
    [ContractInfo]
    public interface IMenu : IVersionable, ICopyable<IMenu>
    {
        int RestaurantId { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 36, DefaultValue = "System.Guid.NewGuid().ToString()")]
        string Guid { get; }
        DateTime? From { get; set; }
        DateTime? To { get; set; }
        [ContractPropertyInfo(MaxLength = 1024)]
        string Notes { get; set; }
        [ContractPropertyInfo(DefaultValue = "Contracts.Modules.Common.LanguageCode.De")]
        LanguageCode LanguageCode { get; set; }
        [ContractPropertyInfo(DefaultValue = "Contracts.Modules.Common.State.Locked")]
        State State { get; set; } 
    }
}
