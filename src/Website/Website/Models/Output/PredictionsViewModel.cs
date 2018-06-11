using System.Collections.Generic;

namespace Website.Models.Output
{
    public class PredictionsViewModel
    {
        public List<PredictionViewModel> Predictions { get; set; }
    }

    public class PredictionViewModel
    {
        public string Id { get; set; }
        public string GameId { get; set; }
        public string FixtureId { get; set; }
        public string PlayerId { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public bool ExtraTime { get; set; }
        public int HomeTeamScoreExtraTime { get; set; }
        public int AwayTeamScoreExtraTime { get; set; }
        public bool Penalties { get; set; }
        public int HomeTeamPenaltiesScore { get; set; }
        public int AwayTeamPenaltiesScored { get; set; }
        public int PredictionPoints { get; set; }
        public FixtureViewModel FixtureViewModel { get; set; }
    }

    public class FixtureViewModel
    {
        public string HomeTeamId { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeamId { get; set; }
        public string AwayTeam { get; set; }
        public string Venue { get; set; }
        public string Date { get; set; }
        public string KickOff { get; set; }
    }
}