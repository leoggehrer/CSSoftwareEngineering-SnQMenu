using SnQMenu.Contracts.Modules.Common;
using System;

namespace SnQMenu.Contracts.Persistence.Food
{
    [ContractInfo]
    public interface IMenuItem : IVersionable, ICopyable<IMenuItem>
    {
        int MenuSectionId { get; set; }
        [ContractPropertyInfo(Required = true, DefaultValueSql = "NEWID()")]
        Guid Guid { get; }
        [ContractPropertyInfo(MaxLength = 256)]
        string ImageUrl { get; set; }
        [ContractPropertyInfo(MaxLength = 64)]
        string InternalName { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256, Order = 1_000)]
        string Name { get; set; }
        [ContractPropertyInfo(MaxLength = 1024, Order = 1_000)]
        string Description { get; set; }
        [ContractPropertyInfo(MaxLength = 30)]
        string AllergenType { get; set; }
        double Price { get; set; }
        int SortOrder { get; set; }
        [ContractPropertyInfo(DefaultValue = "Contracts.Modules.Common.State.Active")]
        State State { get; set; }
    }
}
