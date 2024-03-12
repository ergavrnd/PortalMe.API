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
    [Migration("20240307152524_GantiPassword")]
    partial class GantiPassword
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

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_logged_in");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"),
                            Email = "diansastro@mii.co.id",
                            IsLoggedIn = false,
                            Password = "$2a$12$yfW40aLXSRZgKUgsuXp3qOHa4PltPpbfCSD3MUaQ1Li3hKkulsK/y"
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
                            Id = new Guid("a33d6725-9032-4222-872a-8d75200e3fc7"),
                            AccountId = new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"),
                            RoleId = new Guid("c585ee99-4337-4958-9944-b299063d9595")
                        },
                        new
                        {
                            Id = new Guid("20263e1c-1708-458f-b1d0-d83778a1a4be"),
                            AccountId = new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"),
                            RoleId = new Guid("6638336b-cc35-4541-aca1-f8df691e8073")
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
                            Id = new Guid("94a7bc58-bbaa-4668-8e18-4f61fba30acd"),
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
                            Id = new Guid("87b9553c-94ef-4545-a4dd-bbbd9b879aab"),
                            CompanyId = new Guid("94a7bc58-bbaa-4668-8e18-4f61fba30acd"),
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
                            Id = new Guid("c585ee99-4337-4958-9944-b299063d9595"),
                            RoleName = "Employee"
                        },
                        new
                        {
                            Id = new Guid("6638336b-cc35-4541-aca1-f8df691e8073"),
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
