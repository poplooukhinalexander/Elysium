using System;
using System.Collections.Generic;

namespace Elysium.Web.ApiModels.Feedback
{

	public class FeedbackDTO : UpdateFeedbackDTO
	{			
		/// <summary>
		/// Профиль пользователя, оставившего отзыв.
		/// </summary>
		public UserProfile.UserProfileDTO User { get; set; }
		
		/// <summary>
		/// Фотографии пользователя.
		/// </summary>
		public IEnumerable<Photo.PhotoDTO> Photos { get; set; }

		/// <summary>
		/// Дата-время отзыва.
		/// </summary>
		public DateTime PostDate { get; set; }
	}
}
