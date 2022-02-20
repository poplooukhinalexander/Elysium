using System;

namespace Elysium.Web.ApiModels.UserProfile
{
	public class UserProfileDTO
	{		
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public DateTime? Birthdate { get; set; }
		public string UserPicLink { get; set; }
		
	}
}
