using E_Commerce.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if(!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Description = "administration role" };

                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user role" };

                manager.Create(role);
            }

            if (!context.Users.Any(i => i.UserName == "arifdamar"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser()
                {
                    Name = "Arif",
                    Surname = "Damar",
                    UserName = "arifdamar",
                    Email = "arif660damar@gmail.com"
                };

                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.UserName == "omercsayir"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser()
                {
                    Name = "Omer Cagri",
                    Surname = "Sayir",
                    UserName = "omercsayir",
                    Email = "omercagris@gmail.com"
                };

                manager.Create(user, "654321");
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }
    }
}