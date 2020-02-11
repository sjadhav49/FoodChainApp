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
	/// ErrorController
	/// </summary>
	public class ErrorController : Controller
	{
		// GET: Error

		#region Action Methods

		/// <summary>
		/// Index
		/// </summary>
		/// <returns></returns>
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// NotFound
		/// </summary>
		/// <returns></returns>
		public ActionResult NotFound()
		{
			return View();
		}

		/// <summary>
		/// ServerError
		/// </summary>
		/// <returns></returns>
		public ActionResult ServerError()
		{
			return View();
		}
		#endregion
	}
}