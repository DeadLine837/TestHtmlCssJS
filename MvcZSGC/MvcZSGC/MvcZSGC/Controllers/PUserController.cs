using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcZSGC.Models;

namespace MvcZSGC.Controllers
{
    public class PUserController : Controller
    {
		dhdbEntities entity = new dhdbEntities();
		// GET: PUser
		public ActionResult Index()
        {
            return View();
        }
		public ActionResult Query()
		{
			IQueryable<PUser> query = entity.PUsers;
			List<PUser> list = query.ToList();
			ViewData["list"] = list;
			return View();
		}
		public ActionResult Add()
		{
			return View();
		}
	}
}