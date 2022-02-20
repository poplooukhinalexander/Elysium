using System;
using System.Collections.Generic;

namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для создание маршрута.
	/// </summary>
	public class CreateRouteDTO : BaseRouteDTO
	{
		/// <summary>
		/// ИД. провайдера тура.
		/// </summary>
		public Guid TourProviderId { get; set; }
		
		/// <summary>
		/// Гео-точки маршрута.
		/// </summary>
		public IEnumerable<RoutePointDTO> RoutePoints { get; set; }
		
	}
}
