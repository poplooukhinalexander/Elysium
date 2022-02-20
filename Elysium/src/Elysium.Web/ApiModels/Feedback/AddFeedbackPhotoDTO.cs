using System;

namespace Elysium.Web.ApiModels.Feedback
{
	/// <summary>
	/// DTO для добавления фото к отзыву.
	/// </summary>
	public class AddFeedbackPhotoDTO : Photo.NewPhotoDTO
	{
		public Guid FeedbackId { get; set; }
	}
}
