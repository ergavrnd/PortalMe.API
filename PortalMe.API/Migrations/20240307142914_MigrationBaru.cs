using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class MigrationBaru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_m_employees_tbl_m_accounts_id",
                table: "tbl_m_employees");

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("50a4b893-27cc-4249-9040-33838393ec28"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("10012a96-6a0d-49ac-843b-c82f654aee25"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("7bcaf7ab-0d98-4aa2-b1ca-6a1f4308ac82"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("af42d589-bb4e-4484-bf76-17db908a05a7"));

            migrationBuilder.InsertData(
                table: "tbl_m_companys",
                columns: new[] { "id", "company_name" },
                values: new object[] { new Guid("131f8961-6d7e-406c-99d3-799af3036e89"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("539563ab-410d-4034-ab8e-f2069450e9aa"), "Admin" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("85ba8a10-fc9a-4139-b3fd-586918babfc5"), "Employee" });

            migrationBuilder.InsertData(
                table: "tbl_m_employees",
                columns: new[] { "id", "company_id", "department", "first_name", "last_name", "photo", "Position" },
                values: new object[] { new Guid("bb6b5ea0-8990-4fdb-b00b-62b2dde15abe"), new Guid("131f8961-6d7e-406c-99d3-799af3036e89"), "ADD 1", "Dian", "Sastro", "profile.jpg", "Appdev" });

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "is_logged_in", "password" },
                values: new object[] { new Guid("bb6b5ea0-8990-4fdb-b00b-62b2dde15abe"), "diansastro@mii.co.id", false, "user123" });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("2f83ca48-f415-4283-b6a6-624340b4a052"), new Guid("bb6b5ea0-8990-4fdb-b00b-62b2dde15abe"), new Guid("539563ab-410d-4034-ab8e-f2069450e9aa") });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("f565debb-b8de-4760-8a56-246e4a426064"), new Guid("bb6b5ea0-8990-4fdb-b00b-62b2dde15abe"), new Guid("85ba8a10-fc9a-4139-b3fd-586918babfc5") });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_m_accounts_tbl_m_employees_id",
                table: "tbl_m_accounts",
                column: "id",
                principalTable: "tbl_m_employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_m_accounts_tbl_m_employees_id",
                table: "tbl_m_accounts");

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("2f83ca48-f415-4283-b6a6-624340b4a052"));

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("f565debb-b8de-4760-8a56-246e4a426064"));

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("bb6b5ea0-8990-4fdb-b00b-62b2dde15abe"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("539563ab-410d-4034-ab8e-f2069450e9aa"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("85ba8a10-fc9a-4139-b3fd-586918babfc5"));

            migrationBuilder.DeleteData(
                table: "tbl_m_employees",
                keyColumn: "id",
                keyValue: new Guid("bb6b5ea0-8990-4fdb-b00b-62b2dde15abe"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("131f8961-6d7e-406c-99d3-799af3036e89"));

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "is_logged_in", "password" },
                values: new object[] { new Guid("50a4b893-27cc-4249-9040-33838393ec28"), "", false, "" });

            migrationBuilder.InsertData(
                table: "tbl_m_companys",
                columns: new[] { "id", "company_name" },
                values: new object[] { new Guid("10012a96-6a0d-49ac-843b-c82f654aee25"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[,]
                {
                    { new Guid("7bcaf7ab-0d98-4aa2-b1ca-6a1f4308ac82"), "Admin" },
                    { new Guid("af42d589-bb4e-4484-bf76-17db908a05a7"), "Employee" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_m_employees_tbl_m_accounts_id",
                table: "tbl_m_employees",
                column: "id",
                principalTable: "tbl_m_accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
