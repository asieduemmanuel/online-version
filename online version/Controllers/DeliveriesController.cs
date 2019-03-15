using online_version.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Web.Mvc.Async;
using System.Web.Mvc.Filters;
using System.Web.Profile;
using System.Web.Routing;

namespace online_version.Controllers
{

    public class DeliveriesController : Controller
    {
        // GET: Deliveries
        public ActionResult Index()
        {
            OnlineVersionEntities db = new OnlineVersionEntities();
            return View(db.GetAll().ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        //Saving Data in Database
        public ActionResult Create(Models.Delivering delivering)
        {
            OnlineVersionEntities db = new OnlineVersionEntities();

            if (ModelState.IsValid)
            {
                db.Deliverings.Add(delivering);
                db.SaveChanges();
                //return RedirectToAction("Index", "Deliveries");
                ModelState.Clear();
            }
            return View();
        }
    }

   

}