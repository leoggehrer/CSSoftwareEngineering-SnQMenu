using SnQMenu.Contracts.Modules.Common;

namespace SnQMenu.Contracts.Business.Food
{
    public interface IMenuCard : IIdentifiable, ICopyable<IMenuCard>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 36)]
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
        [ContractPropertyInfo()]
        State State { get; set; }
    }
}
