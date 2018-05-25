﻿using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Dto
{
    public class Game : IEntity
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int Name { get; set; }
        public HashSet<Prediction> Predictions { get; set; }
        public int TotalPoints { get; set; }
    }

    public class Prediction
    {
        public Guid Id { get; set; }
        public Guid FixtureId { get; set; }
        public virtual Fixture Fixture { get; set; }
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