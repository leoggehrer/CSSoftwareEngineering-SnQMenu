using SnQMenu.Contracts.Modules.Common;
using System;

namespace SnQMenu.Contracts.Persistence.Food
{
    [ContractInfo]
    public interface IMenuSection : IVersionable, ICopyable<IMenuSection>
    {
        int MenuId { get; set; }
        [ContractPropertyInfo(Required = true, DefaultValueSql = "NEWID()")]
        Guid Guid { get; }
        [ContractPropertyInfo(MaxLength = 256)]
        string ImageUrl { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        string Name { get; set; }
        [ContractPropertyInfo(MaxLength = 1024)]
        string Description { get; set; }
        int SortOrder { get; set; }
        [ContractPropertyInfo(DefaultValue = "Contracts.Modules.Common.State.Active")]
        State State { get; set; }
    }
}
