using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalMe.API.Models
{
    [Table("tbl_m_companys")]
    public class Company
    {
        [Key]
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Column("company_name", TypeName = "varchar(50)")]
        public string CompanyName { get; set; }

        //Cardinality
        public virtual ICollection<Employee>? Employee { get; set; }
    }

}
