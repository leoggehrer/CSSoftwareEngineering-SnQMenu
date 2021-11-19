//@GeneratedCode
namespace SnQMenu.AspMvc.Models.Persistence.Food
{
    using System;
    public partial class MenuItem : SnQMenu.Contracts.Persistence.Food.IMenuItem
    {
        static MenuItem()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public MenuItem()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.String Name
        {
            get;
            set;
        }
        public System.String Description
        {
            get;
            set;
        }
        public System.Int32 MenuSectionId
        {
            get;
            set;
        }
        public System.String InternalName
        {
            get;
            set;
        }
        public System.String AllergenType
        {
            get;
            set;
        }
        public System.Double Price
        {
            get;
            set;
        }
        public System.Int32 SortOrder
        {
            get;
            set;
        }
        public SnQMenu.Contracts.Modules.Common.State State
        {
            get;
            set;
        }
        = Contracts.Modules.Common.State.Active;
        public void CopyProperties(SnQMenu.Contracts.Persistence.Food.IMenuItem other)
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
                MenuSectionId = other.MenuSectionId;
                InternalName = other.InternalName;
                Name = other.Name;
                Description = other.Description;
                AllergenType = other.AllergenType;
                Price = other.Price;
                SortOrder = other.SortOrder;
                State = other.State;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQMenu.Contracts.Persistence.Food.IMenuItem other, ref bool handled);
        partial void AfterCopyProperties(SnQMenu.Contracts.Persistence.Food.IMenuItem other);
        public static Persistence.Food.MenuItem Create()
        {
            BeforeCreate();
            var result = new Persistence.Food.MenuItem();
            AfterCreate(result);
            return result;
        }
        public static Persistence.Food.MenuItem Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.Food.MenuItem();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.Food.MenuItem Create(SnQMenu.Contracts.Persistence.Food.IMenuItem other)
        {
            BeforeCreate(other);
            var result = new Persistence.Food.MenuItem();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.Food.MenuItem instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.Food.MenuItem instance, object other);
        static partial void BeforeCreate(SnQMenu.Contracts.Persistence.Food.IMenuItem other);
        static partial void AfterCreate(Persistence.Food.MenuItem instance, SnQMenu.Contracts.Persistence.Food.IMenuItem other);
    }
}
