namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerRefactor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GamePlayers", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.GamePlayers", "Player_Id", "dbo.Players");
            DropIndex("dbo.GamePlayers", new[] { "Game_Id" });
            DropIndex("dbo.GamePlayers", new[] { "Player_Id" });
            AddColumn("dbo.Players", "GameId", c => c.Guid(nullable: false));
            AddColumn("dbo.Predictions", "PlayerId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Players", "GameId");
            CreateIndex("dbo.Predictions", "PlayerId");
            AddForeignKey("dbo.Predictions", "PlayerId", "dbo.Players", "Id");
            AddForeignKey("dbo.Players", "GameId", "dbo.Games", "Id");
            DropTable("dbo.GamePlayers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GamePlayers",
                c => new
                    {
                        Game_Id = c.Guid(nullable: false),
                        Player_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Game_Id, t.Player_Id });
            
            DropForeignKey("dbo.Players", "GameId", "dbo.Games");
            DropForeignKey("dbo.Predictions", "PlayerId", "dbo.Players");
            DropIndex("dbo.Predictions", new[] { "PlayerId" });
            DropIndex("dbo.Players", new[] { "GameId" });
            DropColumn("dbo.Predictions", "PlayerId");
            DropColumn("dbo.Players", "GameId");
            CreateIndex("dbo.GamePlayers", "Player_Id");
            CreateIndex("dbo.GamePlayers", "Game_Id");
            AddForeignKey("dbo.GamePlayers", "Player_Id", "dbo.Players", "Id");
            AddForeignKey("dbo.GamePlayers", "Game_Id", "dbo.Games", "Id");
        }
    }
}
