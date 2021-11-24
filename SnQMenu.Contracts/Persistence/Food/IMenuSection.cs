using SnQMenu.Contracts.Modules.Common;

namespace SnQMenu.Contracts.Persistence.Food
{
    [ContractInfo]
    public interface IMenuSection : IVersionable, ICopyable<IMenuSection>
    {
        int MenuId { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 36, DefaultValue = "System.Guid.NewGuid().ToString()")]
        string Guid { get; }
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        string Name { get; set; }
        [ContractPropertyInfo(MaxLength = 1024)]
        string Description { get; set; }
        [ContractPropertyInfo(MaxLength = 256)]
        string ImageUrl { get; set; }
        int SortOrder { get; set; }
        [ContractPropertyInfo(DefaultValue = "Contracts.Modules.Common.State.Active")]
        State State { get; set; }
    }
}
