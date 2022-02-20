using System;

namespace Elysium.Web.ApiModels.Photo
{
	/// <summary>
	/// DTO для обновления заголовка и описания.
	/// </summary>
	public class UpdatePhotoDTO
	{
		/// <summary>
		/// ИД. фото.
		/// </summary>
		public Guid PhotoId { get; set; }		

		/// <summary>
		/// Описание фото.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Название фото.
		/// </summary>
		public string Title { get; set; }
	}
}
