using System.Data.Entity.Migrations;

namespace OwinTest.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<OwinTest.EntityFramework.OwinTestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OwinTest";
        }

        protected override void Seed(OwinTest.EntityFramework.OwinTestDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
