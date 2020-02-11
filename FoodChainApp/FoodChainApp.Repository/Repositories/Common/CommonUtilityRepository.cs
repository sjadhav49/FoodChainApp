#region Namespace
using FoodChainApp.DataAccessLayer;
using FoodChainApp.Models.DashboardDetail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
#endregion

namespace FoodChainApp.Repository.Repositories.Common
{
	/// <summary>
	/// CommonUtilityRepository
	/// </summary>
	public class CommonUtilityRepository : ICommonUtilityRepository
	{
		#region Properties
		private ConnectionStringSettings connectionStringSettings;
		#endregion

		#region Constructor

		/// <summary>
		/// CommonUtilityRepository
		/// </summary>
		public CommonUtilityRepository()
		{
			connectionStringSettings = ConfigurationManager.ConnectionStrings["FoodChainAppDBString"];
		}
		#endregion

		#region Methods

		/// <summary>
		/// getDashboardItems
		/// </summary>
		/// <returns></returns>
		public DashboardModel getDashboardItems()
		{
			DashboardModel dashboardModel = null;
			var dbManager = new DBManager(connectionStringSettings.Name);
			var dataTable = dbManager.getDataTable("SP_GET_DASHBOARD_ITEMS", CommandType.StoredProcedure);
			try
			{
				if (null != dataTable && dataTable.Rows.Count > 0)
				{
					DataRow row = dataTable.Rows[0];
					dashboardModel = new DashboardModel();
					dashboardModel.DataRowToObjectMapper(row);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dashboardModel;
		}

		#endregion
	}
}
