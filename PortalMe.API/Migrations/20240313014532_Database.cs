using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("0088296f-cffc-40bb-9490-2a394ffcd691"));

            migrationBuilder.DeleteData(
                table: "tbl_tr_account_roles",
                keyColumn: "id",
                keyValue: new Guid("c0c98ebf-26bb-492a-bac1-f79dd6444d86"));

            migrationBuilder.DeleteData(
                table: "tbl_m_accounts",
                keyColumn: "id",
                keyValue: new Guid("a1f772d9-0a88-4202-82db-7c7402d74888"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("530ef941-a1b4-4341-a2c5-1efb127c9c98"));

            migrationBuilder.DeleteData(
                table: "tbl_m_roles",
                keyColumn: "id",
                keyValue: new Guid("ee1f4785-64a0-44bb-8a6f-4f48d09b2a0a"));

            migrationBuilder.DeleteData(
                table: "tbl_m_employees",
                keyColumn: "id",
                keyValue: new Guid("a1f772d9-0a88-4202-82db-7c7402d74888"));

            migrationBuilder.DeleteData(
                table: "tbl_m_companys",
                keyColumn: "id",
                keyValue: new Guid("61a4059d-b852-47e3-9438-091f061a56cf"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_m_companys",
                columns: new[] { "id", "company_name" },
                values: new object[] { new Guid("61a4059d-b852-47e3-9438-091f061a56cf"), "Metrodata" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("530ef941-a1b4-4341-a2c5-1efb127c9c98"), "Employee" });

            migrationBuilder.InsertData(
                table: "tbl_m_roles",
                columns: new[] { "id", "role_name" },
                values: new object[] { new Guid("ee1f4785-64a0-44bb-8a6f-4f48d09b2a0a"), "Admin" });

            migrationBuilder.InsertData(
                table: "tbl_m_employees",
                columns: new[] { "id", "company_id", "department", "first_name", "last_name", "photo", "Position" },
                values: new object[] { new Guid("a1f772d9-0a88-4202-82db-7c7402d74888"), new Guid("61a4059d-b852-47e3-9438-091f061a56cf"), "ADD 1", "Dian", "Sastro", "profile.jpg", "Appdev" });

            migrationBuilder.InsertData(
                table: "tbl_m_accounts",
                columns: new[] { "id", "email", "is_logged_in", "password" },
                values: new object[] { new Guid("a1f772d9-0a88-4202-82db-7c7402d74888"), "diansastro@mii.co.id", false, "$2a$11$PfTIlnVJsRUV3/xzwG2X3uVE.2L5uBIWMvXaGc7x.FwF2jA2P8U3O" });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("0088296f-cffc-40bb-9490-2a394ffcd691"), new Guid("a1f772d9-0a88-4202-82db-7c7402d74888"), new Guid("530ef941-a1b4-4341-a2c5-1efb127c9c98") });

            migrationBuilder.InsertData(
                table: "tbl_tr_account_roles",
                columns: new[] { "id", "account_id", "role_id" },
                values: new object[] { new Guid("c0c98ebf-26bb-492a-bac1-f79dd6444d86"), new Guid("a1f772d9-0a88-4202-82db-7c7402d74888"), new Guid("ee1f4785-64a0-44bb-8a6f-4f48d09b2a0a") });
        }
    }
}
