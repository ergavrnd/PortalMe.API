using Microsoft.EntityFrameworkCore;
using PortalMe.API.Models;
using PortalMe.API.Utilities.Handlers;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PortalMe.API.Data
{
    public class PortalMeDbContext : DbContext
    {
        public PortalMeDbContext(DbContextOptions<PortalMeDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<ApplicationPermission> ApplicationPermission { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LogAdmin> LogAdmin { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
                        .HasMany(a => a.AccountRoles)
                        .WithOne(ar => ar.Account)
                        .HasForeignKey(ar => ar.AccountId);

            modelBuilder.Entity<Account>()
                        .HasMany(a => a.ApplicationPermissions)
                        .WithOne(ap => ap.Account)
                        .HasForeignKey(ap => ap.AccountId);

            modelBuilder.Entity<Account>()
                        .HasMany(a => a.LogAdmins)
                        .WithOne(la => la.Account)
                        .HasForeignKey(la => la.AccountId);

            modelBuilder.Entity<Account>()
                        .HasOne(a => a.Employee)
                        .WithOne(e => e.Account)
                        .HasForeignKey<Account>(e => e.Id);

            modelBuilder.Entity<Role>()
                        .HasMany(r => r.AccountRoles)
                        .WithOne(ar => ar.Role)
                        .HasForeignKey(ar => ar.RoleId);

            modelBuilder.Entity<Application>()
                        .HasMany(a => a.ApplicationPermissions)
                        .WithOne(ap => ap.Application)
                        .HasForeignKey(ap => ap.ApplicationId);

            modelBuilder.Entity<Company>()
                        .HasMany(c => c.Employee)
                        .WithOne(e => e.Company)
                        .HasForeignKey(e => e.CompanyId);

           // var roleEmployeeId = Guid.NewGuid();
           // var roleAdminId = Guid.NewGuid();
            //modelBuilder.Entity<Role>()
                        //.HasData(new Role { Id = roleEmployeeId,
                                           // RoleName = "Employee"},
                                // new Role { Id = roleAdminId,
                                            //RoleName = "Admin" });

            //var companyId = Guid.NewGuid();
            //modelBuilder.Entity<Company>()
                       // .HasData(new Company { Id = companyId,
                                               //CompanyName = "Metrodata"}
                                // );

           // var employeeId = Guid.NewGuid();
           // modelBuilder.Entity<Employee>()
                        //.HasData(new Employee { Id = employeeId,
                                               // FirstName = "Dian",
                                                //LastName = "Sastro",
                                                //CompanyId = companyId,
                                                //Department = "ADD 1",
                                                //Position = "Appdev",
                                                //Photo = "profile.jpg"});

            //modelBuilder.Entity<Account>()
                       // .HasData(new Account { Id = employeeId,
                                                //Email = "diansastro@mii.co.id",
                                                //Password = BCrpytHandler.HashPassword("dian"),
                                                //IsLoggedIn = false});

           // modelBuilder.Entity<AccountRole>()
                        //.HasData(new AccountRole { Id = Guid.NewGuid(), AccountId = employeeId,
                                                    //RoleId = roleEmployeeId},
                                 //new AccountRole { Id = Guid.NewGuid(), AccountId = employeeId,
                                                    //RoleId = roleAdminId});

        }
    }
}
