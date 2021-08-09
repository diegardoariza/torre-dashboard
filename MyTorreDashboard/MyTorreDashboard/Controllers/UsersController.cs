using MyTorreDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TorreJsonReader.VO;

namespace MyTorreDashboard.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUsers()
        {
            List<PersonVO> users = new UserViewModels().GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}