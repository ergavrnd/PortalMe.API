using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalMe.API.Models
{
    [Table("tbl_m_applications")]
    public class Application
    {
        [Key]
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Column("name_app", TypeName = "varchar(50)")]
        public string NameApp { get; set; }

        [Column("url_app", TypeName = "varchar(255)")]
        public string UrlApp { get; set; }

        //Cardinality
        public virtual ICollection<ApplicationPermission>? ApplicationPermissions { get; set; }
    }
}
