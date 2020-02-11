#region Namespace
using FoodChainApp.Models.UserDetail;
using System.Web;
using System.Web.Security;
#endregion

namespace FoodChainApp.Session
{
	/// <summary>
	/// UserSession
	/// </summary>
	public static class UserSession
	{
		#region Properties
		public static int UserId { get; set; }
		public static int RoleId { get; set; }
		public static string UserName { get; set; }
		public static string FullName { get; set; }
		public static string RoleName { get; set; }
		#endregion

		#region Methods

		/// <summary>
		/// AddUserSession
		/// </summary>
		/// <param name="userModel"></param>
		public static void AddUserSession(UserModel userModel)
		{
			HttpContext.Current.Session["UserSession"] = userModel;
			FormsAuthentication.SetAuthCookie(userModel.UserName, true);

			UserId = userModel.UserId;
			RoleId = userModel.RoleId;
			UserName = userModel.UserName;
			FullName = userModel.FullName;
			RoleName = userModel.RoleName;
		}

		/// <summary>
		/// GetUserSession
		/// </summary>
		/// <returns></returns>
		public static UserModel GetUserSession()
		{
			UserModel userModel = HttpContext.Current.Session["UserSession"] as UserModel;
			return userModel;
		}

		/// <summary>
		/// IsValidUserSession
		/// </summary>
		/// <returns></returns>
		public static bool IsValidUserSession()
		{
			bool isValid = false;
			UserModel userModel = GetUserSession();
			if (null != userModel && userModel.UserId > 0 && !string.IsNullOrEmpty(HttpContext.Current.User.Identity.Name))
			{
				isValid = true;
			}
			return isValid;
		}

		/// <summary>
		/// ClearUserSession
		/// </summary>
		public static void ClearUserSession()
		{
			HttpContext.Current.Session["UserSession"] = null;
			FormsAuthentication.SignOut();
			HttpContext.Current.Session.Abandon();
		}

		#endregion
	}
}