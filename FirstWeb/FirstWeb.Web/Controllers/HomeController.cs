using System.Web.Mvc;
using FirstWeb.Core.Concrete;

namespace FirstWeb.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _store = new UserRepository(Infrastructure.DBConnection.Instance);
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();

        }
        [HttpGet]
        public JsonResult GetResult()
        {
            var info = _store.FindAll();

            return Json(info, JsonRequestBehavior.AllowGet);
        }
    }
}
