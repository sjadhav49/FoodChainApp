#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
#endregion

namespace FoodChainApp.Controllers
{
	/// <summary>
	/// DashboardController
	/// </summary>
	[Authorize]
	public class DashboardController : Controller
	{
		#region Action Methods

		// GET: Dashboard
		public ActionResult Index()
		{
			return View();
		}
		#endregion
	}
}