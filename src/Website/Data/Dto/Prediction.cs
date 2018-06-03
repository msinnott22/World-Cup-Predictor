using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Dto
{
    public class Prediction
    {
        [Key]
        public Guid Id { get; set; }
        public Guid FixtureId { get; set; }
        public virtual Fixture Fixture { get; set; }
        public Guid GameId { get; set; }
        public virtual Game Game { get; set; }
        public Guid PlayerId { get; set; }
        public virtual Player Player { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public bool ExtraTime { get; set; }
        public int HomeTeamScoreExtraTime { get; set; }
        public int AwayTeamScoreExtraTime { get; set; }
        public bool Penalties { get; set; }
        public int HomeTeamPenaltiesScore { get; set; }
        public int AwayTeamPenaltiesScored { get; set; }
        public int PredictionPoints { get; set; }
    }
}