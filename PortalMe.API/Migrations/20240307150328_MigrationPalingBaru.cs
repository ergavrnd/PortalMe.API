using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class MigrationPalingBaru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "tbl_m_companys",
                columns: new[] { "id", "company_name" },
                values: new object[] { new Guid("493a082f-45fb-4ca5-9e0f-e1e9fd30ffe7"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("a0af8445-e24b-479d-b978-9358cdda1002"), "Employee" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("e74a3f7c-a29a-4fc9-9db5-c2c568d7f4b7"), "Admin" });

            migrationBuilder.InsertData(
                table: "tbl_m_employees",
                columns: new[] { "id", "company_id", "department", "first_name", "last_name", "photo", "Position" },
                values: new object[] { new Guid("a78bd7e4-e433-4f6b-b7b7-c83d3d54160d"), new Guid("493a082f-45fb-4ca5-9e0f-e1e9fd30ffe7"), "ADD 1", "Dian", "Sastro", "profile.jpg", "Appdev" });

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "is_logged_in", "password" },
                values: new object[] { new Guid("a78bd7e4-e433-4f6b-b7b7-c83d3d54160d"), "diansastro@mii.co.id", false, "$2a$12$/wlbCGfx4y5DAIfzeDPCUOEsHjANMiSxRTdM1Eif1Y1qjK2XNKXl." });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("25082770-922b-49cc-8e6f-5f848b90063d"), new Guid("a78bd7e4-e433-4f6b-b7b7-c83d3d54160d"), new Guid("a0af8445-e24b-479d-b978-9358cdda1002") });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("669aa897-4ff8-4b06-8595-fe536ea33773"), new Guid("a78bd7e4-e433-4f6b-b7b7-c83d3d54160d"), new Guid("e74a3f7c-a29a-4fc9-9db5-c2c568d7f4b7") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("25082770-922b-49cc-8e6f-5f848b90063d"));

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("669aa897-4ff8-4b06-8595-fe536ea33773"));

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("a78bd7e4-e433-4f6b-b7b7-c83d3d54160d"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("a0af8445-e24b-479d-b978-9358cdda1002"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("e74a3f7c-a29a-4fc9-9db5-c2c568d7f4b7"));

            migrationBuilder.DeleteData(
                table: "tbl_m_employees",
                keyColumn: "id",
                keyValue: new Guid("a78bd7e4-e433-4f6b-b7b7-c83d3d54160d"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("493a082f-45fb-4ca5-9e0f-e1e9fd30ffe7"));

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
        }
    }
}
