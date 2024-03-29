﻿//@CodeCopy
//MdStart
#if REVISION_ON
using System;

namespace SnQMenu.Contracts.Persistence.Revision
{
    [ContractInfo]
    public partial interface IHistory : IVersionable, ICopyable<IHistory>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 25)]
        string ActionType { get; set; }
        [ContractPropertyInfo(Required = true)]
        DateTime ActionTime { get; set; }
        [ContractPropertyInfo()]
        int IdentityId { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 128)]
        string SubjectName { get; set; }
        [ContractPropertyInfo()]
        int SubjectId { get; set; }
        [ContractPropertyInfo()]
        string JsonData { get; set; }
    }
}
#endif
//MdEnd
