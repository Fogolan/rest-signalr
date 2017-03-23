using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebstackOfLove.Properties;

namespace WebstackOfLove.Models
{
    public class AppDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            User test = new User
            {
                Id = "gsdfgsdfgsdfgasfdg",
                UserName = "TestUser",
                SecretKey = Settings.Default.SecretKey
            };
            context.Users.Add(test);
            context.SaveChanges();
            base.Seed(context);
        }

    }
}