using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class UpgradeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_logged_in",
                table: "tbl_m_accounts");

            migrationBuilder.AddColumn<string>(
                name: "photo",
                table: "tbl_m_applications",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photo",
                table: "tbl_m_applications");

            migrationBuilder.AddColumn<bool>(
                name: "is_logged_in",
                table: "tbl_m_accounts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
