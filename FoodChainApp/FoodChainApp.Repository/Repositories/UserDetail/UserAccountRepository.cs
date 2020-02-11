#region Namespace
using FoodChainApp.DataAccessLayer;
using FoodChainApp.Models.UserDetail;
using FoodChainApp.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
#endregion

namespace FoodChainApp.Repository.Repositories.UserDetail
{
	/// <summary>
	/// UserAccountRepository
	/// </summary>
	public class UserAccountRepository : IUserAccountRepository
	{
		#region Properties
		private ConnectionStringSettings connectionStringSettings;
		#endregion

		#region Constructor

		/// <summary>
		/// UserDetailRepository
		/// </summary>
		public UserAccountRepository()
		{
			connectionStringSettings = ConfigurationManager.ConnectionStrings["FoodChainAppDBString"];
		}
		#endregion

		#region Methods

		/// <summary>
		/// authenticateUser
		/// </summary>
		/// <param name="loginModel"></param>
		/// <returns></returns>
		public UserModel authenticateUser(LoginModel loginModel)
		{
			UserModel userModel = new UserModel();
			var dbManager = new DBManager(connectionStringSettings.Name);
			var parameters = new List<IDbDataParameter>();
			parameters.Add(dbManager.createParameter("@USER_NAME", 100, loginModel.UserName, DbType.String));
			var dataTable = dbManager.getDataTable("USP_AUTHENTICATE_USER", CommandType.StoredProcedure, parameters.ToArray());
			try
			{
				userModel.LoginAction = (int)CommonConstant.LoginAction.INVALID_PASSWORD;
				if (null != dataTable && dataTable.Rows.Count > 0)
				{
					DataRow row = dataTable.Rows[0];
					string currentPassword = Convert.ToString(row["PASSWORD"]);
					if (loginModel.Password.Equals(currentPassword))
					{
						userModel.UserId = row["USER_ID"] as int? ?? 0;
						userModel.UserName = row["USER_NAME"] as string ?? string.Empty;
						userModel.FirstName = row["FIRST_NAME"] as string ?? string.Empty;
						userModel.LastName = row["LAST_NAME"] as string ?? string.Empty;
						userModel.IsActive = row["IS_ACTIVE"] as bool? ?? false;
						userModel.FullName = row["FULL_NAME"] as string ?? string.Empty;
						userModel.RoleId = row["ROLE_ID"] as int? ?? 0;
						userModel.RoleName = row["ROLE_NAME"] as string ?? string.Empty;
						userModel.LoginAction = (int)CommonConstant.LoginAction.SUCCESS;
						userModel.IsValidUser = true;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return userModel;
		}

		#endregion
	}
}
