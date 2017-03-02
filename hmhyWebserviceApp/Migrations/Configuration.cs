namespace hmhyWebserviceApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using hmhyWebserviceApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<hmhyWebserviceApp.Models.hmhyWebserviceAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(hmhyWebserviceApp.Models.hmhyWebserviceAppContext context)
        {
            // Seed the data base with a test user object. 
            context.Users.AddOrUpdate(new MainUser()
            {
                userId = 1,
                userCreds = new UserCredentials()
                {
                    userId = 1,
                    userName = "test",
                    password = "1234"

                }
            });
        }
    }
}
