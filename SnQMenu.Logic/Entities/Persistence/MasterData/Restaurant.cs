//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.MasterData
{
    using System;
    partial class Restaurant : SnQMenu.Contracts.Persistence.MasterData.IRestaurant
    {
        static Restaurant()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Restaurant()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.Guid Guid
        {
            get;
            set;
        }
        public System.String ImageUrl
        {
            get;
            set;
        }
        public System.String UniqueName
        {
            get;
            set;
        }
        public System.String DisplayName
        {
            get;
            set;
        }
        public System.String Description
        {
            get;
            set;
        }
        public System.String WebsiteText
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
        public void CopyProperties(SnQMenu.Contracts.Persistence.MasterData.IRestaurant other)
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
                Guid = other.Guid;
                ImageUrl = other.ImageUrl;
                UniqueName = other.UniqueName;
                DisplayName = other.DisplayName;
                Description = other.Description;
                WebsiteText = other.WebsiteText;
                State = other.State;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQMenu.Contracts.Persistence.MasterData.IRestaurant other, ref bool handled);
        partial void AfterCopyProperties(SnQMenu.Contracts.Persistence.MasterData.IRestaurant other);
        public override bool Equals(object obj)
        {
            if (obj is not SnQMenu.Contracts.Persistence.MasterData.IRestaurant instance)
            {
                return false;
            }
            return base.Equals(instance) && Equals(instance);
        }
        protected bool Equals(SnQMenu.Contracts.Persistence.MasterData.IRestaurant other)
        {
            if (other == null)
            {
                return false;
            }
            return Guid == other.Guid
            && IsEqualsWith(ImageUrl, other.ImageUrl)
            && IsEqualsWith(UniqueName, other.UniqueName)
            && IsEqualsWith(DisplayName, other.DisplayName)
            && IsEqualsWith(Description, other.Description)
            && IsEqualsWith(WebsiteText, other.WebsiteText)
            && State == other.State;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Guid, ImageUrl, UniqueName, DisplayName, Description, WebsiteText, HashCode.Combine(State));
        }
        public static Persistence.MasterData.Restaurant Create()
        {
            BeforeCreate();
            var result = new Persistence.MasterData.Restaurant();
            AfterCreate(result);
            return result;
        }
        public static Persistence.MasterData.Restaurant Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.MasterData.Restaurant();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.MasterData.Restaurant Create(SnQMenu.Contracts.Persistence.MasterData.IRestaurant other)
        {
            BeforeCreate(other);
            var result = new Persistence.MasterData.Restaurant();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.MasterData.Restaurant instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.MasterData.Restaurant instance, object other);
        static partial void BeforeCreate(SnQMenu.Contracts.Persistence.MasterData.IRestaurant other);
        static partial void AfterCreate(Persistence.MasterData.Restaurant instance, SnQMenu.Contracts.Persistence.MasterData.IRestaurant other);
    }
}
