//@GeneratedCode
namespace SnQMenu.Transfer.Models.Persistence.Food
{
    using System;
    public partial class Menu : SnQMenu.Contracts.Persistence.Food.IMenu
    {
        static Menu()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Menu()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.Int32 RestaurantId
        {
            get;
            set;
        }
        public System.String Guid
        {
            get;
            set;
        }
        = System.Guid.NewGuid().ToString();
        public System.DateTime? From
        {
            get;
            set;
        }
        public System.DateTime? To
        {
            get;
            set;
        }
        public System.String Notes
        {
            get;
            set;
        }
        public SnQMenu.Contracts.Modules.Common.LanguageCode LanguageCode
        {
            get;
            set;
        }
        = Contracts.Modules.Common.LanguageCode.De;
        public SnQMenu.Contracts.Modules.Common.State State
        {
            get;
            set;
        }
        = Contracts.Modules.Common.State.Locked;
        public void CopyProperties(SnQMenu.Contracts.Persistence.Food.IMenu other)
        {
            if (other == null)
            {
                throw new System.ArgumentNullException(nameof(other));
            }
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                RowVersion = other.RowVersion;
                RestaurantId = other.RestaurantId;
                Guid = other.Guid;
                From = other.From;
                To = other.To;
                Notes = other.Notes;
                LanguageCode = other.LanguageCode;
                State = other.State;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQMenu.Contracts.Persistence.Food.IMenu other, ref bool handled);
        partial void AfterCopyProperties(SnQMenu.Contracts.Persistence.Food.IMenu other);
        public static Persistence.Food.Menu Create()
        {
            BeforeCreate();
            var result = new Persistence.Food.Menu();
            AfterCreate(result);
            return result;
        }
        public static Persistence.Food.Menu Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.Food.Menu();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.Food.Menu Create(SnQMenu.Contracts.Persistence.Food.IMenu other)
        {
            BeforeCreate(other);
            var result = new Persistence.Food.Menu();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.Food.Menu instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.Food.Menu instance, object other);
        static partial void BeforeCreate(SnQMenu.Contracts.Persistence.Food.IMenu other);
        static partial void AfterCreate(Persistence.Food.Menu instance, SnQMenu.Contracts.Persistence.Food.IMenu other);
    }
}
