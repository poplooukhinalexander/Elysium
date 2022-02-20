using System;

namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// DTO для добавления точки маршрута.
	/// </summary>
	public class AddRoutePointDTO : Route.CreateRoutePointDTO
	{
		/// <summary>
		/// ИД. маршрута.
		/// </summary>
		public Guid RouteId { get; set; }		
	}
}
