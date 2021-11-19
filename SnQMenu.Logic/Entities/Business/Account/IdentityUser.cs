//@GeneratedCode
namespace SnQMenu.Logic.Entities.Business.Account
{
    using System;
    partial class IdentityUser : SnQMenu.Contracts.Business.Account.IIdentityUser
    {
        static IdentityUser()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public IdentityUser()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public void CopyProperties(SnQMenu.Contracts.Business.Account.IIdentityUser other)
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
                OneItem.CopyProperties(other.OneItem);
                AnotherItem.CopyProperties(other.AnotherItem);
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQMenu.Contracts.Business.Account.IIdentityUser other, ref bool handled);
        partial void AfterCopyProperties(SnQMenu.Contracts.Business.Account.IIdentityUser other);
        public static Business.Account.IdentityUser Create()
        {
            BeforeCreate();
            var result = new Business.Account.IdentityUser();
            AfterCreate(result);
            return result;
        }
        public static Business.Account.IdentityUser Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Business.Account.IdentityUser();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Business.Account.IdentityUser Create(SnQMenu.Contracts.Business.Account.IIdentityUser other)
        {
            BeforeCreate(other);
            var result = new Business.Account.IdentityUser();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Business.Account.IdentityUser instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Business.Account.IdentityUser instance, object other);
        static partial void BeforeCreate(SnQMenu.Contracts.Business.Account.IIdentityUser other);
        static partial void AfterCreate(Business.Account.IdentityUser instance, SnQMenu.Contracts.Business.Account.IIdentityUser other);
    }
}
