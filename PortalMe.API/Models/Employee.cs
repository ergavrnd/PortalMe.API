using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalMe.API.Models
{

    [Table("tbl_m_employees")]
    public class Employee
    {
        [Key]
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Column("company_id", TypeName = "char(36)")]
        public Guid CompanyId { get; set; }

        [Column("first_name", TypeName = "varchar(50)")]
        public string FirstName { get; set; } = string.Empty;

        [Column("last_name", TypeName = "varchar(50)")]
        public string? LastName { get; set; }

        [Column("photo", TypeName = "varchar(255)")]
        public string Photo { get; set; } = string.Empty;

        [Column("department", TypeName = "varchar(50)")]
        public string Department { get; set; }

        [Column("Position", TypeName = "varchar(50)")]
        public string Position { get; set; }


        // Cardinality
        public virtual Account? Account { get; set; }
        public virtual Company? Company { get; set; }
    }
}
