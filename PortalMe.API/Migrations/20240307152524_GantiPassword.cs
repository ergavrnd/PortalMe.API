using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class GantiPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("94a7bc58-bbaa-4668-8e18-4f61fba30acd"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("6638336b-cc35-4541-aca1-f8df691e8073"), "Admin" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("c585ee99-4337-4958-9944-b299063d9595"), "Employee" });

            migrationBuilder.InsertData(
                table: "tbl_m_employees",
                columns: new[] { "id", "company_id", "department", "first_name", "last_name", "photo", "Position" },
                values: new object[] { new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"), new Guid("94a7bc58-bbaa-4668-8e18-4f61fba30acd"), "ADD 1", "Dian", "Sastro", "profile.jpg", "Appdev" });

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "is_logged_in", "password" },
                values: new object[] { new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"), "diansastro@mii.co.id", false, "$2a$12$yfW40aLXSRZgKUgsuXp3qOHa4PltPpbfCSD3MUaQ1Li3hKkulsK/y" });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("20263e1c-1708-458f-b1d0-d83778a1a4be"), new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"), new Guid("6638336b-cc35-4541-aca1-f8df691e8073") });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("a33d6725-9032-4222-872a-8d75200e3fc7"), new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"), new Guid("c585ee99-4337-4958-9944-b299063d9595") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("20263e1c-1708-458f-b1d0-d83778a1a4be"));

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("a33d6725-9032-4222-872a-8d75200e3fc7"));

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("6638336b-cc35-4541-aca1-f8df691e8073"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("c585ee99-4337-4958-9944-b299063d9595"));

            migrationBuilder.DeleteData(
                table: "tbl_m_employees",
                keyColumn: "id",
                keyValue: new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("94a7bc58-bbaa-4668-8e18-4f61fba30acd"));

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
    }
}
