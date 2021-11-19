//@CodeCopy

using SnQMenu.Contracts;

namespace SnQMenu.Logic.Entities
{
	internal abstract partial class VersionEntity : IdentityEntity, IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
