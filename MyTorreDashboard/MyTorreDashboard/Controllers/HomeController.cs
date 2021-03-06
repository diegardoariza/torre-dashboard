using MyTorreDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TorreJsonReader.VO;

namespace MyTorreDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is My Torre Dashboard (MTD)?.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Who Developer My Torre Dashboard (MTD) ? .";

            return View();
        }

        public JsonResult GetUsers()
        {
            List<PersonVO> users = new UserViewModels().GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}