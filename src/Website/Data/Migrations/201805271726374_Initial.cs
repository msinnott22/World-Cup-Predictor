namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fixtures",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        KickOff = c.DateTime(nullable: false),
                        Venue = c.String(),
                        HomeTeamId = c.Guid(nullable: false),
                        HomeTeamScore = c.Int(nullable: false),
                        AwayTeamId = c.Guid(nullable: false),
                        AwayTeamScore = c.Int(nullable: false),
                        ExtraTimeAvailable = c.Boolean(nullable: false),
                        PenaltiesAvailable = c.Boolean(nullable: false),
                        HomeTeamScoreInExtraTime = c.Int(nullable: false),
                        AwayTeamScoreInExtraTime = c.Int(nullable: false),
                        HomeTeamPenaltiesScore = c.Int(nullable: false),
                        AwayTeamPenaltiesScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.AwayTeamId)
                .ForeignKey("dbo.Teams", t => t.HomeTeamId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.AwayTeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        GroupId = c.Guid(nullable: false),
                        GamesPlayed = c.Int(nullable: false),
                        GamesWon = c.Int(nullable: false),
                        GamesDrawn = c.Int(nullable: false),
                        GamesLost = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        GoalsFor = c.Int(nullable: false),
                        GoalsAgainst = c.Int(nullable: false),
                        GoalDifference = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                        Name = c.Int(nullable: false),
                        TotalPoints = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Predictions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FixtureId = c.Guid(nullable: false),
                        HomeTeamScore = c.Int(nullable: false),
                        AwayTeamScore = c.Int(nullable: false),
                        ExtraTime = c.Boolean(nullable: false),
                        HomeTeamScoreExtraTime = c.Int(nullable: false),
                        AwayTeamScoreExtraTime = c.Int(nullable: false),
                        Penalties = c.Boolean(nullable: false),
                        HomeTeamPenaltiesScore = c.Int(nullable: false),
                        AwayTeamPenaltiesScored = c.Int(nullable: false),
                        PredictionPoints = c.Int(nullable: false),
                        Game_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fixtures", t => t.FixtureId)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.FixtureId)
                .Index(t => t.Game_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Predictions", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Predictions", "FixtureId", "dbo.Fixtures");
            DropForeignKey("dbo.Fixtures", "HomeTeamId", "dbo.Teams");
            DropForeignKey("dbo.Fixtures", "AwayTeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "GroupId", "dbo.Groups");
            DropIndex("dbo.Predictions", new[] { "Game_Id" });
            DropIndex("dbo.Predictions", new[] { "FixtureId" });
            DropIndex("dbo.Teams", new[] { "GroupId" });
            DropIndex("dbo.Fixtures", new[] { "AwayTeamId" });
            DropIndex("dbo.Fixtures", new[] { "HomeTeamId" });
            DropTable("dbo.Predictions");
            DropTable("dbo.Games");
            DropTable("dbo.Groups");
            DropTable("dbo.Teams");
            DropTable("dbo.Fixtures");
        }
    }
}
