using Abc.Mvc.WebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.Mvc.WebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {

            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name= "admin", Description= "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "serhatyazicioglu"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name="serhat",Surname="yazıcıoğlu",UserName="serhatyazicioglu",Email="serhatyazicioglu@gmail.com"};
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id,"admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "ahmetkayaci"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "ahmet", Surname = "kayacı", UserName = "ahmetkayaci", Email = "ahmetkayaci@gmail.com" };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }
    }
}