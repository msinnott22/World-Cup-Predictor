using System.Linq;
using System.Web.Mvc;
using Data.Dto;
using Data.Interfaces;
using Microsoft.AspNet.Identity;
using Website.Models.Output;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWriteStore _writeStore;

        public HomeController(IWriteStore writeStore)
        {
            _writeStore = writeStore;
        }

        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            return RedirectToAction("Login", "Account");
        }

        [ChildActionOnly]
        public ActionResult TopNav()
        {
            var claims = ((System.Security.Claims.ClaimsIdentity) User.Identity).Claims;
            var claim = claims.SingleOrDefault(m => m.Type == "UserName");
            var userId = User.Identity.GetUserId();
            var game = _writeStore.Query<Game>().Where(g => g.AdminUserId == userId)
                .OrderByDescending(g => g.Created).FirstOrDefault();

            var vm = new TopNavViewModel()
            {
                Username = claim?.Value,
                IsGameAdmin = game != null,
                GameId = game?.Id.ToString()
            };

            return PartialView("_TopNav", vm);
        }
    }
}