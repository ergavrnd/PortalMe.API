using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalMe.API.Models
{
    [Table("tbl_tr_application_permissions")]
    public class ApplicationPermission
    {
        [Key]
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Column("account_id", TypeName = "char(36)")]
        public Guid AccountId { get; set; }

        [Column("application_id", TypeName = "char(36)")]
        public Guid ApplicationId { get; set; }

        // Cardinality
        public virtual Application? Application { get; set; }
        public virtual Account? Account { get; set; }
    }
}
