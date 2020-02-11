#region Namespace
using FoodChainApp.Filters;
using System.Web;
using System.Web.Mvc;
#endregion

namespace FoodChainApp
{
	/// <summary>
	/// FilterConfig
	/// </summary>
	public class FilterConfig
	{
		#region Methods

		/// <summary>
		/// RegisterGlobalFilters
		/// </summary>
		/// <param name="filters"></param>
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
			filters.Add(new AuthorizeAttribute());
			filters.Add(new CustomUserAuthenticationFilter());
		}
		#endregion
	}
}
