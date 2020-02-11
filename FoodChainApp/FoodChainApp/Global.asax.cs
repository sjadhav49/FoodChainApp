#region Namespace
using FoodChainApp.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
#endregion

namespace FoodChainApp
{
	/// <summary>
	/// MvcApplication
	/// </summary>
	public class MvcApplication : System.Web.HttpApplication
	{
		#region Methods

		/// <summary>
		/// Application_Start
		/// </summary>
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		/// <summary>
		/// Application_Error
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void Application_Error(object sender, EventArgs e)
		{
			Exception exception = Server.GetLastError();
			LogHelper.Error(exception.Message, exception);
			Response.Clear();
		}
		#endregion
	}
}
