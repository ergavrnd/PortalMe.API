using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalMe.API.Models
{
    [Table("tbl_m_roles")]
    public class Role
    {
        [Key]
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Column("role_name", TypeName = "varchar(50)")]
        public string RoleName { get; set; }

        //Cardinality
        public virtual ICollection<AccountRole>? AccountRoles { get; set; }
    }
}
