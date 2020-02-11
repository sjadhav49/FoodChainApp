#region Namespace
using FoodChainApp.Models.UserDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace FoodChainApp.BusinessLayer.UserDetail
{
	/// <summary>
	/// IUserAccountProvider
	/// </summary>
	public interface IUserAccountProvider
	{
		#region Method Declarations

		/// <summary>
		/// authenticateUser
		/// </summary>
		/// <param name="loginModel"></param>
		/// <returns></returns>
		UserModel authenticateUser(LoginModel loginModel);
		#endregion
	}
}
