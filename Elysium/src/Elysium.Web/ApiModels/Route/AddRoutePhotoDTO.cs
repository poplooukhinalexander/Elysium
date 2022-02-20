using System;

namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для добавления фото к маршруту.
	/// </summary>
	public class AddRoutePhotoDTO : Photo.NewPhotoDTO
	{
		/// <summary>
		/// ИД. маршрута.
		/// </summary>
		public Guid RouteId { get; set; }	

		/// <summary>
		/// True - фото на заставке.
		/// </summary>
		public bool IsMain { get; set; }
	}
}
