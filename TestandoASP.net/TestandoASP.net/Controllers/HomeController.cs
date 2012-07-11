using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Controllers
{
	[HandleError]
	public class HomeController : Controller
	{
		private static int NumeroDeAcessos { get; set; }
		public ActionResult Index ()
		{
			HomeController.NumeroDeAcessos++;
			ViewBag.Acessos = HomeController.NumeroDeAcessos;
			return View();
		}
	}
}

