namespace MIS4200.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MIS4200.DALSDTWO.MIS4200ContextSD2>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MIS4200.DALSDTWO.MIS4200ContextSD2";
        }

        protected override void Seed(MIS4200.DALSDTWO.MIS4200ContextSD2 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
