using System.Linq;
using System.Web.Mvc;
using Data.Dto;
using Data.Interfaces;
using Microsoft.AspNet.Identity;
using Website.Interfaces;
using Website.Models.Input;
using Website.Models.Output;

namespace Website.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameManager _gameManager;
        private readonly IWriteStore _writeStore;

        public GameController(IGameManager gameManager, IWriteStore writeStore)
        {
            _gameManager = gameManager;
            _writeStore = writeStore;
        }

        public ActionResult Index()
        {
            var game = this.LoadGame(User.Identity.GetUserId());

            if (game == null)
            {
                return View();
            }

            var vm = new GameViewModel()
            {
                Id = game.Id.ToString(),
                Name = game.Name,
                JoinCode = game.JoinCode,
                Players = (int)game.Players?.Count,
                Predictions = (int)game.Predictions?.Count
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult CreateGame(NewGameModel model)
        {
            if (ModelState.IsValid)
            {
                model.AdminUserId = User.Identity.GetUserId();
                var success = _gameManager.CreateNewGame(model);

                if (success)
                {
                    _writeStore.SaveChanges();
                }
            }

            var game = this.LoadGame(model.AdminUserId);

            if (game == null)
            {
                return View("Index");
            }

            var vm = new GameViewModel()
            {
                Id = game.Id.ToString(),
                Name = game.Name,
                JoinCode = game.JoinCode,
                Players = (int) game.Players?.Count,
                Predictions = (int) game.Predictions?.Count
            };

            return View("Index", vm);
        }

        private Game LoadGame(string adminUserId)
        {
            var game = _writeStore.Query<Game>().Where(g => g.AdminUserId == adminUserId)
                .OrderByDescending(g => g.Created).FirstOrDefault();
            return game;
        }
    }
}