#region Namespace
using FoodChainApp.Models.DashboardDetail;
using FoodChainApp.Repository.Repositories.Common;
using System.Collections.Generic;
#endregion

namespace FoodChainApp.BusinessLayer.Common
{
	/// <summary>
	/// CommonUtilityProvider
	/// </summary>
	public class CommonUtilityProvider : ICommonUtilityProvider
	{
		#region Properties
		private readonly ICommonUtilityRepository repository;
		#endregion

		#region Constructor

		/// <summary>
		/// CommonUtilityProvider
		/// </summary>
		public CommonUtilityProvider()
		{
			this.repository = new CommonUtilityRepository();
		}
		#endregion

		#region Methods

		/// <summary>
		/// getDashboardItems
		/// </summary>
		/// <returns></returns>
		public DashboardModel getDashboardItems()
		{
			return repository.getDashboardItems();
		}
		#endregion
	}
}
