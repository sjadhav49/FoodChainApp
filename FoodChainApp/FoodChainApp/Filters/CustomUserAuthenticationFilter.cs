#region Namespace
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using FoodChainApp.Session;
#endregion

namespace FoodChainApp.Filters
{
	/// <summary>
	/// CustomUserAuthenticationFilter
	/// </summary>
	public class CustomUserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
	{
		#region Methods

		/// <summary>
		/// OnAuthentication
		/// </summary>
		/// <param name="filterContext"></param>
		public void OnAuthentication(AuthenticationContext filterContext)
		{
			string actionName = filterContext.RouteData.Values["action"].ToString();
			string controllerName = filterContext.RouteData.Values["controller"].ToString();

			if ((actionName != "Index" && controllerName != "Account"))
			{
				if (!UserSession.IsValidUserSession())
					filterContext.Result = new HttpUnauthorizedResult();
			}
		}

		/// <summary>
		/// OnAuthenticationChallenge
		/// </summary>
		/// <param name="filterContext"></param>
		public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
		{
			if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
			{
				//Redirecting the user to the Login View of Account Controller  
				filterContext.Result = new RedirectToRouteResult(
				new RouteValueDictionary
				{
					 { "controller", "Account" },
					 { "action", "Index" }
				});
			}
		}
		#endregion
	}
}