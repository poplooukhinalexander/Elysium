using System;
using System.Collections.Generic;


namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для представления информации о маршруте.
	/// </summary>
	public class RouteDTO : CreateRouteDTO
	{
		/// <summary>
		/// ИД. маршрута.
		/// </summary>
		public Guid RouteId { get; set; }		

		/// <summary>
		/// Дистанция маршрута в км.
		/// </summary>
		public double DistanceKm { get; set; }

		/// <summary>
		/// Перепад высот в м.
		/// </summary>
		public double HeightDiffM { get; set; }

		/// <summary>
		/// Главное фото. Загружается по ?expand=MainPhoto.
		/// </summary>
		public Photo.PhotoDTO MainPhoto { get; set; }

		/// <summary>
		/// Фотогалерея. Загружается по ?expand=Gallery.
		/// </summary>
		public IEnumerable<Photo.PhotoDTO> Gallery { get; set; }	
		
		/// <summary>
		/// Провайдер тура. Загружается по ?expand=TourProvider.
		/// </summary>
		public TourProvider.TourProviderDTO TourProvider { get; set; }
	}
}
