//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.Account
{
    using System;
    partial class Access : SnQMenu.Contracts.Persistence.Account.IAccess
    {
        static Access()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Access()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.Int32 IdentityId
        {
            get;
            set;
        }
        public System.String Key
        {
            get;
            set;
        }
        public System.String Value
        {
            get;
            set;
        }
        = string.Empty;
        public void CopyProperties(SnQMenu.Contracts.Persistence.Account.IAccess other)
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
                IdentityId = other.IdentityId;
                Key = other.Key;
                Value = other.Value;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQMenu.Contracts.Persistence.Account.IAccess other, ref bool handled);
        partial void AfterCopyProperties(SnQMenu.Contracts.Persistence.Account.IAccess other);
        public override bool Equals(object obj)
        {
            if (obj is not SnQMenu.Contracts.Persistence.Account.IAccess instance)
            {
                return false;
            }
            return base.Equals(instance) && Equals(instance);
        }
        protected bool Equals(SnQMenu.Contracts.Persistence.Account.IAccess other)
        {
            if (other == null)
            {
                return false;
            }
            return IdentityId == other.IdentityId
            && IsEqualsWith(Key, other.Key)
            && IsEqualsWith(Value, other.Value);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(IdentityId, Key, Value);
        }
        public static Persistence.Account.Access Create()
        {
            BeforeCreate();
            var result = new Persistence.Account.Access();
            AfterCreate(result);
            return result;
        }
        public static Persistence.Account.Access Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.Account.Access();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.Account.Access Create(SnQMenu.Contracts.Persistence.Account.IAccess other)
        {
            BeforeCreate(other);
            var result = new Persistence.Account.Access();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.Account.Access instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.Account.Access instance, object other);
        static partial void BeforeCreate(SnQMenu.Contracts.Persistence.Account.IAccess other);
        static partial void AfterCreate(Persistence.Account.Access instance, SnQMenu.Contracts.Persistence.Account.IAccess other);
    }
}
