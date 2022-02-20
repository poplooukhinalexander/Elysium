using System;

namespace Elysium.Web.ApiModels.UserProfile
{
	public class CreateUserProfileDTO : UserProfileDTO
	{		
		public Guid AccountId { get; set; }
	}
}
