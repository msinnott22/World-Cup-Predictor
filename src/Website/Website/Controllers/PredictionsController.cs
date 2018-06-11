using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Data.Dto;
using Data.Interfaces;
using Microsoft.AspNet.Identity;
using Website.Models.Output;

namespace Website.Controllers
{
    public class PredictionsController : Controller
    {
        private readonly IWriteStore _writeStore;

        public PredictionsController(IWriteStore writeStore)
        {
            _writeStore = writeStore;
        }

        // GET: Predictions
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var player = _writeStore.Query<Player>().FirstOrDefault(p => p.UserId == userId);

            if (player == null)
            {
                return View();
            }

            var hasExistingPredictions = _writeStore.Query<Prediction>().Any(p => p.PlayerId == player.Id);
            var fixtures = _writeStore.Query<Fixture>().ToList();
            var vm = new PredictionsViewModel();
            var predictions = new List<PredictionViewModel>();

            if (hasExistingPredictions)
            {
                foreach (var fixture in fixtures)
                {
                    predictions.Add(new PredictionViewModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        FixtureId = fixture.Id.ToString(),
                        PlayerId = player.Id.ToString(),
                        GameId = player.GameId.ToString(),
                        FixtureViewModel = new FixtureViewModel()
                        {
                            HomeTeamId = fixture.HomeTeamId.ToString(),
                            AwayTeamId = fixture.AwayTeamId.ToString(),
                            HomeTeam = fixture.HomeTeam.Abbreviation,
                            AwayTeam = fixture.AwayTeam.Abbreviation,
                            Venue = fixture.Venue,
                            Date = fixture.Date.ToString("MMM dd, yyyy"),
                            KickOff = fixture.KickOff.ToString("HH:mm")
                        }
                    });
                }
            }

            var existingPredictions = _writeStore.Query<Prediction>().Where(p => p.PlayerId == player.Id).ToList();

            foreach (var prediction in existingPredictions)
            {
                predictions.Add(new PredictionViewModel()
                {
                    Id = prediction.Id.ToString(),
                    FixtureId = prediction.FixtureId.ToString(),
                    PlayerId = prediction.FixtureId.ToString(),
                    GameId = prediction.GameId.ToString(),
                    HomeTeamScore = prediction.HomeTeamScore,
                    AwayTeamScore = prediction.AwayTeamScore,
                    HomeTeamScoreExtraTime = prediction.HomeTeamScoreExtraTime,
                    ExtraTime = prediction.ExtraTime,
                    Penalties = prediction.Penalties,
                    AwayTeamScoreExtraTime = prediction.AwayTeamScoreExtraTime,
                    AwayTeamPenaltiesScored = prediction.AwayTeamPenaltiesScored,
                    HomeTeamPenaltiesScore = prediction.HomeTeamPenaltiesScore,
                    PredictionPoints = prediction.PredictionPoints,
                    FixtureViewModel = new FixtureViewModel()
                    {
                        HomeTeamId = prediction.Fixture.HomeTeamId.ToString(),
                        AwayTeamId = prediction.Fixture.AwayTeamId.ToString(),
                        Venue = prediction.Fixture.Venue,
                        HomeTeam = prediction.Fixture.HomeTeam.Abbreviation,
                        AwayTeam = prediction.Fixture.AwayTeam.Abbreviation,
                        Date = prediction.Fixture.Date.ToString("MMM dd, yyyy"),
                        KickOff = prediction.Fixture.KickOff.ToString("HH:mm")
                    }
                });
            }

            vm.Predictions = predictions;

            return View(vm);
        }
    }
}