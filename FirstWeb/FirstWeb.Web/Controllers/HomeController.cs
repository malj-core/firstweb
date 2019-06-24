using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWeb.Core.Concrete;

namespace FirstWeb.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository store = new UserRepository(Infrastructure.DBConnection.Instance);
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public JsonResult GetResult()
        {
            var info = store.FindAll();

            return Json(info, JsonRequestBehavior.AllowGet);
        }
    }
}
