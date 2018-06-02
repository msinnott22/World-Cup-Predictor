using System.Linq;
using System.Web.Mvc;
using Data.Dto;
using Data.Interfaces;
using Microsoft.AspNet.Identity;
using Website.Models.Output;

namespace Website.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IWriteStore _dbStore;

        public DashboardController(IWriteStore writeStore)
        {
            _dbStore = writeStore;
        }

        // GET: Index
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var gameExists = _dbStore.Query<Game>().Any(x => x.AdminUserId == userId);
            var viewModel = new DashboardViewModel()
            {
                HasExistingGame = gameExists
            };

            return View(viewModel);
        }
    }
}