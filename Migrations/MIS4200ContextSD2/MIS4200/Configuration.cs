namespace MIS4200.Migrations.MIS4200Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configurations : DbMigrationsConfiguration<MIS4200.DALSDTWO.MIS4200ContextSD2>
    {
        public Configurations ()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MIS4200ContextSD2";
            ContextKey = "MIS4200.DAL.MIS4200ContextSD2";
        }

        protected override void Seed(MIS4200.DALSDTWO.MIS4200ContextSD2 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
