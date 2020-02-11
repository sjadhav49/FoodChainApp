#region Namespace
using FoodChainApp.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
#endregion

namespace FoodChainApp.Models.UserDetail
{
	/// <summary>
	/// UserDetail
	/// </summary>
	public class UserModel
	{
		public UserModel()
		{
			LoginAction = (int)CommonConstant.LoginAction.USER_NOT_EXISTS;
			IsValidUser = false;
		}

		#region Properties

		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int RoleId { get; set; } 
		public bool IsActive { get; set; }

		//Other properties
		public bool IsValidUser { get; set; }
		public string FullName { get; set; }
		public string RoleName { get; set; }
		public int LoginAction { get; set; }

		#endregion
	}

	/// <summary>
	/// LoginModel
	/// </summary>
	public class LoginModel
	{
		[Required(ErrorMessage = "Please enter Username")]
		[DataType(DataType.EmailAddress)]
		[StringLength(150, ErrorMessage = "Do not enter more than 150 characters")]
		[MaxLength(150)]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Please enter Password")]
		[DataType(DataType.Password)]
		[StringLength(50, ErrorMessage = "Do not enter more than 50 characters")]
		[MaxLength(50)]
		public string Password { get; set; }
	}
}
