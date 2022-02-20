using System;

namespace Elysium.Web.ApiModels.UserProfile
{
	public class UploadUserPictureDTO
	{
		public Guid UserId { get; set; }
		public string PictureBase64 { get; set; }
	}
}
