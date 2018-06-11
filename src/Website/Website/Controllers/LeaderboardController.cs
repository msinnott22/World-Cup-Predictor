using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Dto;
using Data.Identity;
using Data.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Website.Models.Output;

namespace Website.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly IWriteStore _writeStore;

        public LeaderboardController(IWriteStore writeStore)
        {
            _writeStore = writeStore;
        }

        // GET: Leaderboard
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var player = _writeStore.Query<Player>().FirstOrDefault(p => p.UserId == userId);

            if (player == null)
            {
                return View();
            }

            var game = _writeStore.Load<Game>(player.GameId);

            if (game == null)
            {
                return View();
            }

            var rows = new List<Row>();

            foreach (var gamePlayer in game.Players)
            {
                string username;
                using (var identityDb = HttpContext.GetOwinContext().Get<IdentityDbContext>())
                {
                    username = identityDb.Users.FirstOrDefault(x => x.Id == gamePlayer.UserId)?.UserName;
                }

                rows.Add(new Row()
                {
                    Name = username,
                    Points = gamePlayer.Game.TotalPoints
                });
            }
            
            var vm = new LeaderboardViewModel()
            {
                Rows = rows
            };

            return View(vm);
        }
    }
}