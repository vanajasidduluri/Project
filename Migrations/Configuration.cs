namespace MyCodeMvc1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MyCodeMvc1.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<MyCodeMvc1.Data.MyCodeMvc1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyCodeMvc1.Data.MyCodeMvc1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Employees.AddOrUpdate(
        p => p.Id,
                  new Employee(){ Name = "Andrew Peters",Address="Us" },
                  new Employee(){ Name = "Brice Lambson",Address="Newyork" },
                  new Employee(){ Name = "Rowan Miller",Address="Australia" }
                );

        }
    }
}
