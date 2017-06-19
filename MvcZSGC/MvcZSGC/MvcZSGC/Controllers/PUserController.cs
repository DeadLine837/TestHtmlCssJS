using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZSGC.Controllers
{
    public class PUserController : Controller
    {
        // GET: PUser
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult Query()
		{
			return View();
		}
		public ActionResult Add()
		{
			return View();
		}
	}
}