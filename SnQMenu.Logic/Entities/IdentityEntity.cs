//@CodeCopy
//MdStart
using SnQMenu.Contracts;

namespace SnQMenu.Logic.Entities
{
    internal abstract partial class IdentityEntity : EntityObject, IIdentifiable
	{
		public virtual int Id { get; set; }
    }
}
//MdEnd
