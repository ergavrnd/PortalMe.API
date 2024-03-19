using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class Seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_m_companys",
                columns: new[] { "id", "company_name" },
                values: new object[] { new Guid("87e29e4d-7e6a-4805-b4f3-29e7742e2286"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("276106a8-af59-4042-b4f6-3f4c9293d76a"), "Employee" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("bf583c10-40c4-4d0e-8231-95b506cb20a9"), "Admin" });

            migrationBuilder.InsertData(
                table: "tbl_m_employees",
                columns: new[] { "id", "company_id", "department", "first_name", "last_name", "photo", "Position" },
                values: new object[] { new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"), new Guid("87e29e4d-7e6a-4805-b4f3-29e7742e2286"), "ADD 1", "Dian", "Sastro", "profile.jpg", "Appdev" });

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "password" },
                values: new object[] { new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"), "diansastro@mii.co.id", "$2a$12$PHeBvqaf14PFYhIrF36dwOyVOeDLiLq2zkENbQfLxQtYEOeZQkxja" });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("5683138f-bc44-4a0b-b3db-e94daa0187ce"), new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"), new Guid("bf583c10-40c4-4d0e-8231-95b506cb20a9") });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("eaa028da-c51c-468a-9e09-713b96e24571"), new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"), new Guid("276106a8-af59-4042-b4f6-3f4c9293d76a") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("5683138f-bc44-4a0b-b3db-e94daa0187ce"));

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("eaa028da-c51c-468a-9e09-713b96e24571"));

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("276106a8-af59-4042-b4f6-3f4c9293d76a"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("bf583c10-40c4-4d0e-8231-95b506cb20a9"));

            migrationBuilder.DeleteData(
                table: "tbl_m_employees",
                keyColumn: "id",
                keyValue: new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("87e29e4d-7e6a-4805-b4f3-29e7742e2286"));
        }
    }
}
