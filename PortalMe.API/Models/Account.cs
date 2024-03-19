using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PortalMe.API.Models
{
    [Table("tbl_m_accounts")]
    public class Account { 
    [Key]
    [Column("id", TypeName = "char(36)")]
    public Guid Id { get; set; }

    [Column("email", TypeName = "varchar(50)")]
    public string Email { get; set; } = string.Empty;

    [Column("password", TypeName = "varchar(50)")]
    public string Password { get; set; } = string.Empty;

    // Cardinality
    public virtual Employee? Employee { get; set; }
    public virtual ICollection<AccountRole>? AccountRoles { get; set; }

    public virtual ICollection<ApplicationPermission>? ApplicationPermissions { get; set; }

    public virtual ICollection<LogAdmin>? LogAdmins { get; set; }
    }
}