using CmsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsApi.Data
{
    public class InitDb
    {
        public static void Init(CmsApiContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pages.Any())
            {
                return;
            }

            // Populate Pages table
            var pages = new Page[]
            {
                new Page{ Title="Home", Slug="home", Content="Home content", HasSidebar = "no" },
                new Page{ Title="About", Slug="about", Content="About content", HasSidebar = "no" },
                new Page{ Title="Services", Slug="services", Content="Services content", HasSidebar = "no" },
                new Page{ Title="Contact", Slug="contact", Content="Contact content", HasSidebar = "no" }
            };
            foreach(var p in pages)
            {
                context.Pages.Add(p);
            }
            context.SaveChanges();

            // Populate Sidebar table
            var sidebar = new Sidebar
            {
                Content = "Sidebar content"
            };
            context.Sidebar.Add(sidebar);
            context.SaveChanges();

            // Populate Sidebar table
            var user = new User
            {
                Username = "admin",
                Password = "pass",
                IsAdmin = "yes"
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
