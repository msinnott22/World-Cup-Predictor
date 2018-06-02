namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayersUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Predictions", new[] { "Game_Id" });
            RenameColumn(table: "dbo.Predictions", name: "Game_Id", newName: "GameId");
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GamePlayers",
                c => new
                    {
                        Game_Id = c.Guid(nullable: false),
                        Player_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Game_Id, t.Player_Id })
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .Index(t => t.Game_Id)
                .Index(t => t.Player_Id);
            
            AddColumn("dbo.Games", "AdminUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "JoinCode", c => c.String(maxLength: 8));
            AlterColumn("dbo.Games", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.Predictions", "GameId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Predictions", "GameId");
            DropColumn("dbo.Games", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.GamePlayers", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.GamePlayers", "Game_Id", "dbo.Games");
            DropIndex("dbo.GamePlayers", new[] { "Player_Id" });
            DropIndex("dbo.GamePlayers", new[] { "Game_Id" });
            DropIndex("dbo.Predictions", new[] { "GameId" });
            AlterColumn("dbo.Predictions", "GameId", c => c.Guid());
            AlterColumn("dbo.Games", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.Games", "JoinCode");
            DropColumn("dbo.Games", "Created");
            DropColumn("dbo.Games", "AdminUserId");
            DropTable("dbo.GamePlayers");
            DropTable("dbo.Players");
            RenameColumn(table: "dbo.Predictions", name: "GameId", newName: "Game_Id");
            CreateIndex("dbo.Predictions", "Game_Id");
        }
    }
}
