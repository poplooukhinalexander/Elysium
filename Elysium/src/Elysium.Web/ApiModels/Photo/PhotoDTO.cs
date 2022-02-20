using System;


namespace Elysium.Web.ApiModels.Photo
{
	/// <summary>
	/// DTO для получения информации о фото.
	/// </summary>
	public class PhotoDTO
	{
		/// <summary>
		/// ИД. фото.
		/// </summary>
		public Guid PhotoId { get; set; }

		/// <summary>
		/// Название фото.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание фото.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Ссылка на фото.
		/// </summary>
		public string StandardLink { get; set; }

		/// <summary>
		/// Ссылка на preview фото.
		/// </summary>
		public string PreviewLink { get; set; }

		/// <summary>
		/// Индекс порядка фото в галлерее.
		/// </summary>
		public int OrderIndex { get; set; }
	}
}
