//@CodeCopy
//MdStart
#if ACCOUNT_ON
using SnQMenu.Contracts.Persistence.Account;

namespace SnQMenu.Contracts.Business.Account
{
    public partial interface IAppAccess : IOneToMany<IIdentity, IRole>, ICopyable<IAppAccess>
    {

    }
}
#endif
//MdEnd
