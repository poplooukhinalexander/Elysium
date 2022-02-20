using System;

namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для обновления описания точки маршрута.
	/// </summary>
	public class UpdateRoutePointDescriptionDTO
	{
		/// <summary>
		/// ИД. точки маршрута.
		/// </summary>
		public Guid RoutePointId { get; set; }		
		
		/// <summary>
		/// Описание точки маршрута.
		/// </summary>
		public string Description { get; set; }
	}
}
