using SnQMenu.Contracts.Modules.Common;
using System;

namespace SnQMenu.Contracts.Persistence.MasterData
{
    [ContractInfo]
    public interface IRestaurant : IVersionable, ICopyable<IRestaurant>
    {
        [ContractPropertyInfo(Required = true, DefaultValueSql = "NEWID()")]
        Guid Guid { get; }
        [ContractPropertyInfo(MaxLength = 256)]
        string ImageUrl { get; set; }
        [ContractPropertyInfo(Required = true, IsUnique = true, MaxLength = 256)]
        string UniqueName { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        string DisplayName { get; set; }
        [ContractPropertyInfo(Required = false, MaxLength = 2048)]
        string Description { get; set; }
        [ContractPropertyInfo(MaxLength = 1024)]
        string WebsiteText { get; set; }
        [ContractPropertyInfo(DefaultValue = "Contracts.Modules.Common.State.Active")]
        State State { get; set; }
    }
}
