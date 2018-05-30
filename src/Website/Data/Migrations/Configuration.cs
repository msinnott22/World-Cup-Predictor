namespace Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Seed;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.WcpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.WcpContext context)
        {
            Groups.Execute(context);
            Teams.Execute(context);

            context.SaveChanges();
        }
    }
}
