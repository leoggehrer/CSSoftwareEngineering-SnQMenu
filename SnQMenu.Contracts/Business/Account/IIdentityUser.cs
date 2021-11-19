//@CodeCopy
//MdStart
#if ACCOUNT_ON
using SnQMenu.Contracts.Persistence.Account;

namespace SnQMenu.Contracts.Business.Account
{
    public partial interface IIdentityUser : IOneToAnother<IIdentity, IUser>, ICopyable<IIdentityUser>
    {
    }
}
#endif
//MdEnd
