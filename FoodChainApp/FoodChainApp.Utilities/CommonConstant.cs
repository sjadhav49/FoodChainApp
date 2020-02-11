#region Namespace
using System;
#endregion

namespace FoodChainApp.Utilities
{
	/// <summary>
	/// CommonConstant
	/// </summary>
	public static class CommonConstant
	{
		#region Enums

		/// <summary>
		/// LoginAction
		/// </summary>
		public enum LoginAction
		{
			FAILED = 0,
			SUCCESS = 1,
			USER_NOT_EXISTS = 2,
			INVALID_PASSWORD = 3
		}

		#endregion
	}
}
