namespace GetYourlLine.Migrations
{
    using GetYourlLine.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GetYourlLine.Models.CustomerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GetYourlLine.Models.CustomerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Customers.AddOrUpdate(
                c=>c.Service,
                    new Customer{ Service="Existing", FirstName="John", LastName="Robert", Email="J@gmail.com", PhoneNumber="1234567899"},
                    new Customer{ Service="New Applicant", FirstName="Anna", LastName="Mark", Email="a@gmail.com", PhoneNumber="2345678999"},
                    new Customer{ Service="Existing", FirstName="Sam", LastName="Ross", Email="s@gmail.com", PhoneNumber="3456789999"}

            );
        }
    }
    
}
