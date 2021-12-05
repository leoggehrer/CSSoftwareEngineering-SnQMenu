using SnQMenu.Contracts.Modules.Common;
using System;

namespace SnQMenu.Contracts.Business.Food
{
    public interface IMenuCard : IIdentifiable, ICopyable<IMenuCard>
    {
        Guid Guid { get; }
        string ImageUrl { get; set; }
        string Text { get; set; }
        string SubText { get; set; }
        double Price { get; set; }
        string Currency { get; set; }
        string AllergenType { get; set; }
        int SortOrder { get; set; }
        string Tag { get; set; }
        State State { get; set; }
        MenuCardItemType ItemType { get; set; }
    }
}
