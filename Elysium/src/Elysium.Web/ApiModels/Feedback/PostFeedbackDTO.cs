using System;

namespace Elysium.Web.ApiModels.Feedback
{
	/// <summary>
	/// DTO для поста отзыва о туре.
	/// </summary>
	public class PostFeedbackDTO : BaseFeedbackDTO
	{
		/// <summary>
		/// ИД тура.
		/// </summary>
		public Guid TourId { get; set; }

		/// <summary>
		/// ИД. пользователя.
		/// </summary>
		public Guid UserId { get; set; }		
	}
}
