﻿using SnQMenu.Contracts.Modules.Common;

namespace SnQMenu.Contracts.Persistence.Food
{
    [ContractInfo]
    public interface IMenuItem : IVersionable, ICopyable<IMenuItem>
    {
        int MenuSectionId { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 36, DefaultValue = "System.Guid.NewGuid().ToString()")]
        string Guid { get; }
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
