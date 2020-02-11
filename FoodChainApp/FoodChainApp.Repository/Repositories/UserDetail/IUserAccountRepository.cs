#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodChainApp.Models.UserDetail;
#endregion

namespace FoodChainApp.Repository.Repositories.UserDetail
{
	/// <summary>
	/// IUserAccountRepository
	/// </summary>
	public interface IUserAccountRepository
	{
		#region Method Declarations

		/// <summary>
		/// loginModel
		/// </summary>
		/// <param name="loginModel"></param>
		/// <returns></returns>
		UserModel authenticateUser(LoginModel loginModel);
		#endregion
	}
}
