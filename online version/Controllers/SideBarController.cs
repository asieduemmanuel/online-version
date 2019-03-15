using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace online_version.Controllers
{
    public class SideBarController : Controller
    {
        // GET: SideBar
        public ActionResult Index()
        {
            return View();
        }
    }
}