#region Namespace
using FoodChainApp.Models.DashboardDetail;
using System.Collections.Generic;
#endregion

namespace FoodChainApp.BusinessLayer.Common
{
	/// <summary>
	/// ICommonUtilityProvider
	/// </summary>
	public interface ICommonUtilityProvider
	{
		#region Method Declarations
		DashboardModel getDashboardItems();

		#endregion
	}
}
