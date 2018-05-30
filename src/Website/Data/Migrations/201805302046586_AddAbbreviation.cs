namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAbbreviation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Abbreviation", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Abbreviation");
        }
    }
}
