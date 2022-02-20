namespace Elysium.Web.ApiModels.Photo
{
	/// <summary>
	/// DTO для загрузки нового фото.
	/// </summary>
	public class NewPhotoDTO
	{
		/// <summary>
		/// Название фото.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Фото в base64.
		/// </summary>
		public string PhotoBase64 { get; set; }

		/// <summary>
		/// Preview фото в base64.
		/// </summary>
		public string PreviewPhotoBase64 { get; set; }
	}
}
