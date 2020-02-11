#region Namespace
using System.Web.Mvc;
using System.Web.Security;
using FoodChainApp.BusinessLayer.UserDetail;
using FoodChainApp.Models.UserDetail;
using FoodChainApp.Session;
#endregion

namespace FoodChainApp.Controllers
{
	/// <summary>
	/// AccountController
	/// </summary>
	[Authorize]
	public class AccountController : Controller
	{
		// GET: Account

		#region Properties
		private IUserAccountProvider userAccountProvider = null;
		#endregion

		#region Constructor

		/// <summary>
		/// AccountController
		/// </summary>
		public AccountController()
		{
			userAccountProvider = new UserAccountProvider();
		}
		#endregion

		#region Methods

		/// <summary>
		/// Login
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[AllowAnonymous]
		public ActionResult Login()
		{
			return View();
		}

		/// <summary>
		/// Login
		/// </summary>
		/// <param name="loginModel"></param>
		/// <returns></returns>
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public ActionResult Login(LoginModel loginModel)
		{
			if (ModelState.IsValid)
			{
				UserModel userModel = userAccountProvider.authenticateUser(loginModel);
				if (userModel.IsValidUser)
				{
					UserSession.AddUserSession(userModel);
					return RedirectToAction("Index", "Dashboard");
				}
				ModelState.AddModelError("", "Invalid Username or Password");
			}
			return View(loginModel);
		}

		/// <summary>
		/// LogOff
		/// </summary>
		/// <returns></returns>
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public ActionResult LogOff()
		{
			UserSession.ClearUserSession();
			return RedirectToAction("Login", "Account");
		}

		#endregion
	}
}