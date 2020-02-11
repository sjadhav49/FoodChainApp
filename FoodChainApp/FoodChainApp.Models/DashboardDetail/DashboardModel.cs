#region Namespace
using System;
using System.Data;
#endregion

namespace FoodChainApp.Models.DashboardDetail
{
	/// <summary>
	/// DashboardModel
	/// </summary>
	public class DashboardModel
	{
		#region Properties
		public int TotalCustomer { get; set; }
		public int TotalOrder { get; set; }
		public int TotalProduct { get; set; }
		public int TotalUser { get; set; }
		#endregion

		#region Methods

		/// <summary>
		/// DataRowToObjectMapper
		/// </summary>
		/// <param name="dataTable"></param>
		public void DataRowToObjectMapper(DataRow row)
		{
			this.TotalCustomer = row["TOTAL_CUSTOMERS"] as int? ?? 0;
			this.TotalOrder = row["TOTAL_ORDERS"] as int? ?? 0;
			this.TotalProduct = row["TOTAL_PRODUCTS"] as int? ?? 0;
			this.TotalUser = row["TOTAL_USERS"] as int? ?? 0;
		}

		#endregion
	}
}
