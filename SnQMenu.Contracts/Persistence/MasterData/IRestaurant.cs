using SnQMenu.Contracts.Modules.Common;

namespace SnQMenu.Contracts.Persistence.MasterData
{
    [ContractInfo]
    public interface IRestaurant : IVersionable, ICopyable<IRestaurant>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 36, DefaultValue = "System.Guid.NewGuid().ToString()")]
        string Guid { get; }
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
