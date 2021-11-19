//@GeneratedCode
namespace SnQMenu.Logic.Entities.Persistence.Account
{
    partial class Access
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("IdentityId")]
        public SnQMenu.Logic.Entities.Persistence.Account.Identity Identity
        {
            get;
            set;
        }
    }
}
