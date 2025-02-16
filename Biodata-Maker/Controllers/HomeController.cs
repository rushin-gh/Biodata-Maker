using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biodata_Maker.Models;

namespace Biodata_Maker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserDataDisplay(User user)
        {
            return View(user);
        }
    }
}