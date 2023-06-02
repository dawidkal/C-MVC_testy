using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMVC.Controllers
{
    public class KursyController : Controller
    {
        // GET: Kursy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {
            return View();
        }
    }
}