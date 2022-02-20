using System;

namespace Elysium.Web.ApiModels.Photo
{
	/// <summary>
	/// DTO для обновления индекса порядка фото.
	/// </summary>
	public class UpdatePhotoOrderIndexDTO
	{
		/// <summary>
		/// ИД. фото.
		/// </summary>
		public Guid PhotoId { get; set; }

		/// <summary>
		/// Новый индекс порядка фото в галерее.
		/// </summary>
		public int OrderIndex { get; set; }
	}
}
