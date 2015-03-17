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
            AutomaticMigrationsEnabled = true;
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
                    new Customer{ Service="New", FirstName="Anna", LastName="Mark", Email="a@gmail.com", PhoneNumber="2345678999"},
                    new Customer{ Service="Existing", FirstName="Sam", LastName="Ross", Email="s@gmail.com", PhoneNumber="3456789999"},
                    new Customer{ Service="New", FirstName="Simon", LastName="Robert", Email="si@gmail.com", PhoneNumber="456789123"},
                    new Customer{ Service="New", FirstName="Rachel", LastName="Mark", Email="ra@gmail.com", PhoneNumber="5678912345"},
                    new Customer{ Service="Existing", FirstName="Kate", LastName="Ross", Email="k@gmail.com", PhoneNumber="6789123456"}
            );
            //context.CustomerDetails.AddOrUpdate(
            //    d => d.CustomerID,
            //    new CustomerDetail {CurrentTime = "10:00AM", RegisteredTime="9:00Am", EstimatedMinutes= 60, CustomersNumber= 2 },
            //    new CustomerDetail {CurrentTime="11:00Am", RegisteredTime="10:00Am", EstimatedMinutes= 60, CustomersNumber= 3 },
            //    new CustomerDetail {CurrentTime="09:00Am", RegisteredTime="8:30Am", EstimatedMinutes=30, CustomersNumber= 2 },
            //    new CustomerDetail {CurrentTime="12:00Am", RegisteredTime="11:20Am", EstimatedMinutes= 40, CustomersNumber= 1 }

            // );         
        }
    }
    
}
