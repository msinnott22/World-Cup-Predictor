namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixUserIdType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "AdminUserId", c => c.String());
            AlterColumn("dbo.Players", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Games", "AdminUserId", c => c.Int(nullable: false));
        }
    }
}
