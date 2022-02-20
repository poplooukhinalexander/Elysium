using System;

namespace Elysium.Web.ApiModels.UserProfile
{
	public class GetUserProfileDTO : UserProfileDTO
	{
		public Guid Id { get; set; }
		public string UserPictureLink { get; set; }
	}
}
