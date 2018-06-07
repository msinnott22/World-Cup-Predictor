using System.Web.Mvc;
using Website.Models.Output;

namespace Website.Controllers
{
    public class LeaderboardController : Controller
    {
        // GET: Leaderboard
        public ActionResult Index()
        {
            var vm = new LeaderboardViewModel()
            {

            };

            return View();
        }
    }
}