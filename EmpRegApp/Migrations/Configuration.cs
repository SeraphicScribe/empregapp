namespace EmpRegApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmpRegApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<EmpRegApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        bool AddUserAndRole(EmpRegApp.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "user1@live.com",
            };
            ir = um.Create(user, "passworD321");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(EmpRegApp.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);

            context.Employees.AddOrUpdate(p => p.nicNumber,
               new Employee
               {
                   firstName = "Debra",
                   lastName = "Garcia",
                   streetAddress = "1234 Main St",
                   city = "Redmond",
                   nicNumber = "138679309v",
                   birthDate = DateTime.ParseExact("15/06/1989 ", "dd/MM/yyyy ", null),
                   mobileNumber = "087-8864539",
                   email = "debra@example.com"
               },
               new Employee
               {
                   firstName = "Thorsten",
                   lastName = "Weinrich",
                   streetAddress = "5678 1st Ave W",
                   city = "Redmond",
                   nicNumber = "190267930v",
                   birthDate = DateTime.ParseExact("10/07/1990 ", "dd/MM/yyyy ", null),
                   mobileNumber = "076-3764536",
                   email = "thorsten@example.com"

               },
               new Employee
               {
                   firstName = "Yuhong",
                   lastName = "Li",
                   streetAddress = "9012 State st",
                   city = "Redmond",
                   nicNumber = "351026939v",
                   birthDate = DateTime.ParseExact("12/09/1987 ", "dd/MM/yyyy ", null),
                   mobileNumber = "075-2503533",
                   email = "yuhong@example.com"
               },
               new Employee
               {
                   firstName = "Jon",
                   lastName = "Orton",
                   streetAddress = "3456 Maple St",
                   city = "Redmond",
                   nicNumber = "326938509v",
                   birthDate = DateTime.ParseExact("13/11/1970 ", "dd/MM/yyyy ", null),
                   mobileNumber = "077-3563032",
                   email = "jon@example.com"
               },
                new Employee
                {
                    firstName = "Diliana",
                    lastName = "Alexieva-Bosseva",
                    streetAddress = "7890 2nd Ave E",
                    city = "Redmond",
                    nicNumber = "328509295v",
                    birthDate = DateTime.ParseExact("01/06/1979 ", "dd/MM/yyyy ", null),
                    mobileNumber = "035-6320235",
                    email = "diliana@example.com"
                }
            );
        }
    }
}
