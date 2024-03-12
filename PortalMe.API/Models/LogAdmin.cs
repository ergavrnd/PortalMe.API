using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalMe.API.Models
{
    [Table("tbl_m_log_admins")]
    public class LogAdmin
    {
        [Key]
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Column("account_id", TypeName = "char(36)")]
        public Guid AccountId { get; set; }

        [Column("action", TypeName = "varchar(50)")]
        public string Action { get; set; } = string.Empty;

        [Column("time")] public DateTime Time { get; set; }

        //Cardinality
        public virtual Account? Account { get; set; }
    }

}
