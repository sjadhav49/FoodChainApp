#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodChainApp.Models.UserDetail;
using FoodChainApp.Repository.Repositories.UserDetail;
#endregion

namespace FoodChainApp.BusinessLayer.UserDetail
{
	/// <summary>
	/// UserAccountProvider
	/// </summary>
	public class UserAccountProvider : IUserAccountProvider
	{
		#region Properties
		private readonly IUserAccountRepository repository;
		#endregion

		#region Constructor

		/// <summary>
		/// UserDetailProvider
		/// </summary>
		public UserAccountProvider()
		{
			this.repository = new UserAccountRepository();
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
			return repository.authenticateUser(loginModel);
		}

		#endregion
	}
}
