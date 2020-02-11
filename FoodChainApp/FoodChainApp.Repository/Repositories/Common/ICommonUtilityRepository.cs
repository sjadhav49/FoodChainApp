#region Namespace
using FoodChainApp.Models.DashboardDetail;
using System.Collections.Generic;
#endregion

namespace FoodChainApp.Repository.Repositories.Common
{
	/// <summary>
	/// ICommonUtility
	/// </summary>
	public interface ICommonUtilityRepository
	{
		#region Method Declarations
		DashboardModel getDashboardItems();

		#endregion
	}
}
