//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.Food
{
    using System;
    partial class MenuSection : SnQMenu.Contracts.Persistence.Food.IMenuSection
    {
        static MenuSection()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public MenuSection()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.Int32 MenuId
        {
            get;
            set;
        }
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
        public System.String ImageUrl
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
        public void CopyProperties(SnQMenu.Contracts.Persistence.Food.IMenuSection other)
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
                MenuId = other.MenuId;
                Name = other.Name;
                Description = other.Description;
                ImageUrl = other.ImageUrl;
                SortOrder = other.SortOrder;
                State = other.State;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQMenu.Contracts.Persistence.Food.IMenuSection other, ref bool handled);
        partial void AfterCopyProperties(SnQMenu.Contracts.Persistence.Food.IMenuSection other);
        public override bool Equals(object obj)
        {
            if (obj is not SnQMenu.Contracts.Persistence.Food.IMenuSection instance)
            {
                return false;
            }
            return base.Equals(instance) && Equals(instance);
        }
        protected bool Equals(SnQMenu.Contracts.Persistence.Food.IMenuSection other)
        {
            if (other == null)
            {
                return false;
            }
            return MenuId == other.MenuId
            && IsEqualsWith(Name, other.Name)
            && IsEqualsWith(Description, other.Description)
            && IsEqualsWith(ImageUrl, other.ImageUrl)
            && SortOrder == other.SortOrder
            && State == other.State;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(MenuId, Name, Description, ImageUrl, SortOrder, State);
        }
        public static Persistence.Food.MenuSection Create()
        {
            BeforeCreate();
            var result = new Persistence.Food.MenuSection();
            AfterCreate(result);
            return result;
        }
        public static Persistence.Food.MenuSection Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.Food.MenuSection();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.Food.MenuSection Create(SnQMenu.Contracts.Persistence.Food.IMenuSection other)
        {
            BeforeCreate(other);
            var result = new Persistence.Food.MenuSection();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.Food.MenuSection instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.Food.MenuSection instance, object other);
        static partial void BeforeCreate(SnQMenu.Contracts.Persistence.Food.IMenuSection other);
        static partial void AfterCreate(Persistence.Food.MenuSection instance, SnQMenu.Contracts.Persistence.Food.IMenuSection other);
    }
}
