using System.Data.Entity.Migrations;

namespace Entity_Framework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Entity_Framework.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Entity_Framework.Context.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
