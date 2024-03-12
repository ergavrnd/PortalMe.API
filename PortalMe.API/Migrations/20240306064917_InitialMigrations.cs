using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalMe.API.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_m_accounts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    email = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_logged_in = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_accounts", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_m_applications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    name_app = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    url_app = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_applications", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_m_companys",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    company_name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_companys", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_m_roles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    role_name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_roles", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_m_log_admins",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    account_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    action = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_log_admins", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_m_log_admins_tbl_m_accounts_account_id",
                        column: x => x.account_id,
                        principalTable: "tbl_m_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_tr_application_permissions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    account_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    application_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_tr_application_permissions", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_tr_application_permissions_tbl_m_accounts_account_id",
                        column: x => x.account_id,
                        principalTable: "tbl_m_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_tr_application_permissions_tbl_m_applications_applicatio~",
                        column: x => x.application_id,
                        principalTable: "tbl_m_applications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_m_employees",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    company_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    first_name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    photo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    department = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_employees", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_m_employees_tbl_m_accounts_id",
                        column: x => x.id,
                        principalTable: "tbl_m_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_m_employees_tbl_m_companys_company_id",
                        column: x => x.company_id,
                        principalTable: "tbl_m_companys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_tr_account_roles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    account_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    role_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_tr_account_roles", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_tr_account_roles_tbl_m_accounts_account_id",
                        column: x => x.account_id,
                        principalTable: "tbl_m_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_tr_account_roles_tbl_m_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "tbl_m_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_employees_company_id",
                table: "tbl_m_employees",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_log_admins_account_id",
                table: "tbl_m_log_admins",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_account_roles_account_id",
                table: "tbl_tr_account_roles",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_account_roles_role_id",
                table: "tbl_tr_account_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_application_permissions_account_id",
                table: "tbl_tr_application_permissions",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_application_permissions_application_id",
                table: "tbl_tr_application_permissions",
                column: "application_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_m_employees");

            migrationBuilder.DropTable(
                name: "tbl_m_log_admins");

            migrationBuilder.DropTable(
                name: "tbl_tr_account_roles");

            migrationBuilder.DropTable(
                name: "tbl_tr_application_permissions");

            migrationBuilder.DropTable(
                name: "tbl_m_companys");

            migrationBuilder.DropTable(
                name: "tbl_m_roles");

            migrationBuilder.DropTable(
                name: "tbl_m_accounts");

            migrationBuilder.DropTable(
                name: "tbl_m_applications");
        }
    }
}
