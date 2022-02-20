using System;

namespace Elysium.Web.ApiModels.Feedback
{
	/// <summary>
	/// DTO для обновления отзыва о туре.
	/// </summary>
	public class UpdateFeedbackDTO : BaseFeedbackDTO
	{
		/// <summary>
		/// ИД. обновляемого отзыва.
		/// </summary>
		public Guid FeedbackId { get; set; }
	}
}
