﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalMe.API.Data;

#nullable disable

namespace PortalMe.API.Migrations
{
    [DbContext(typeof(PortalMeDbContext))]
    [Migration("20240313145943_Seeder")]
    partial class Seeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PortalMe.API.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"),
                            Email = "diansastro@mii.co.id",
                            Password = "$2a$12$PHeBvqaf14PFYhIrF36dwOyVOeDLiLq2zkENbQfLxQtYEOeZQkxja"
                        });
                });

            modelBuilder.Entity("PortalMe.API.Models.AccountRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("account_id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("tbl_tr_account_roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eaa028da-c51c-468a-9e09-713b96e24571"),
                            AccountId = new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"),
                            RoleId = new Guid("276106a8-af59-4042-b4f6-3f4c9293d76a")
                        },
                        new
                        {
                            Id = new Guid("5683138f-bc44-4a0b-b3db-e94daa0187ce"),
                            AccountId = new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"),
                            RoleId = new Guid("bf583c10-40c4-4d0e-8231-95b506cb20a9")
                        });
                });

            modelBuilder.Entity("PortalMe.API.Models.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("NameApp")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name_app");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("photo");

                    b.Property<string>("UrlApp")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url_app");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_applications");
                });

            modelBuilder.Entity("PortalMe.API.Models.ApplicationPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("account_id");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("char(36)")
                        .HasColumnName("application_id");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("tbl_tr_application_permissions");
                });

            modelBuilder.Entity("PortalMe.API.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("company_name");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_companys");

                    b.HasData(
                        new
                        {
                            Id = new Guid("87e29e4d-7e6a-4805-b4f3-29e7742e2286"),
                            CompanyName = "Metrodata"
                        });
                });

            modelBuilder.Entity("PortalMe.API.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)")
                        .HasColumnName("company_id");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("department");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("photo");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("tbl_m_employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e29dcba-7025-4bd3-98f2-2a01bdcf1e37"),
                            CompanyId = new Guid("87e29e4d-7e6a-4805-b4f3-29e7742e2286"),
                            Department = "ADD 1",
                            FirstName = "Dian",
                            LastName = "Sastro",
                            Photo = "profile.jpg",
                            Position = "Appdev"
                        });
                });

            modelBuilder.Entity("PortalMe.API.Models.LogAdmin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("account_id");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("action");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("time");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("tbl_m_log_admins");
                });

            modelBuilder.Entity("PortalMe.API.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role_name");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("276106a8-af59-4042-b4f6-3f4c9293d76a"),
                            RoleName = "Employee"
                        },
                        new
                        {
                            Id = new Guid("bf583c10-40c4-4d0e-8231-95b506cb20a9"),
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("PortalMe.API.Models.Account", b =>
                {
                    b.HasOne("PortalMe.API.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("PortalMe.API.Models.Account", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PortalMe.API.Models.AccountRole", b =>
                {
                    b.HasOne("PortalMe.API.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalMe.API.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PortalMe.API.Models.ApplicationPermission", b =>
                {
                    b.HasOne("PortalMe.API.Models.Account", "Account")
                        .WithMany("ApplicationPermissions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalMe.API.Models.Application", "Application")
                        .WithMany("ApplicationPermissions")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Application");
                });

            modelBuilder.Entity("PortalMe.API.Models.Employee", b =>
                {
                    b.HasOne("PortalMe.API.Models.Company", "Company")
                        .WithMany("Employee")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("PortalMe.API.Models.LogAdmin", b =>
                {
                    b.HasOne("PortalMe.API.Models.Account", "Account")
                        .WithMany("LogAdmins")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("PortalMe.API.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");

                    b.Navigation("ApplicationPermissions");

                    b.Navigation("LogAdmins");
                });

            modelBuilder.Entity("PortalMe.API.Models.Application", b =>
                {
                    b.Navigation("ApplicationPermissions");
                });

            modelBuilder.Entity("PortalMe.API.Models.Company", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PortalMe.API.Models.Employee", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("PortalMe.API.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });
#pragma warning restore 612, 618
        }
    }
}