using System;

namespace Data.Dto
{
    public class Fixture
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime KickOff { get; set; }
        public string Venue { get; set; }
        public Guid HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public Guid AwayTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }
        public int AwayTeamScore { get; set; }
        public bool ExtraTimeAvailable { get; set; }
        public bool PenaltiesAvailable { get; set; }
        public int HomeTeamScoreInExtraTime { get; set; }
        public int AwayTeamScoreInExtraTime { get; set; }
        public int HomeTeamPenaltiesScore { get; set; }
        public int AwayTeamPenaltiesScore { get; set; }
    }
}
