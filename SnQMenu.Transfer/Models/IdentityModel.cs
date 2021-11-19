//@CodeCopy

namespace SnQMenu.Transfer.Models
{
    public partial class IdentityModel : TransferModel, Contracts.IIdentifiable
	{
		public virtual int Id { get; set; }
	}
}
