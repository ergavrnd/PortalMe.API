using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class GantiSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("a46d3ae0-49fa-4549-8159-88e4535d4343"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("0af9fe84-d6ca-45c1-b7ef-e67507c84a77"), "Employee" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("a4bfa4f4-c763-4424-b1f7-0554a1fce433"), "Admin" });

            migrationBuilder.InsertData(
                table: "tbl_m_employees",
                columns: new[] { "id", "company_id", "department", "first_name", "last_name", "photo", "Position" },
                values: new object[] { new Guid("272e2d9a-81b0-4405-88bc-8e4106853242"), new Guid("a46d3ae0-49fa-4549-8159-88e4535d4343"), "ADD 1", "Dian", "Sastro", "profile.jpg", "Appdev" });

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "is_logged_in", "password" },
                values: new object[] { new Guid("272e2d9a-81b0-4405-88bc-8e4106853242"), "diansastro@mii.co.id", false, "$2a$12$mTQ5p0pYwlVizGgqvcC2O.5Sp97riuTVCWa3tEFxSayvdQg9w1GhG" });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("421c7b68-9864-46b4-b4c9-60f7046cbf84"), new Guid("272e2d9a-81b0-4405-88bc-8e4106853242"), new Guid("a4bfa4f4-c763-4424-b1f7-0554a1fce433") });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("90c04ed8-27e0-4b23-9d29-f753a76c570a"), new Guid("272e2d9a-81b0-4405-88bc-8e4106853242"), new Guid("0af9fe84-d6ca-45c1-b7ef-e67507c84a77") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("421c7b68-9864-46b4-b4c9-60f7046cbf84"));

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("90c04ed8-27e0-4b23-9d29-f753a76c570a"));

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("272e2d9a-81b0-4405-88bc-8e4106853242"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("0af9fe84-d6ca-45c1-b7ef-e67507c84a77"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("a4bfa4f4-c763-4424-b1f7-0554a1fce433"));

            migrationBuilder.DeleteData(
                table: "tbl_m_employees",
                keyColumn: "id",
                keyValue: new Guid("272e2d9a-81b0-4405-88bc-8e4106853242"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("a46d3ae0-49fa-4549-8159-88e4535d4343"));

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
    }
}
