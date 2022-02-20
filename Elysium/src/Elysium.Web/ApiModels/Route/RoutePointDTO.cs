using System;
using System.Collections.Generic;


namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для точки маршрута.
	/// </summary>
	public class RoutePointDTO : CreateRoutePointDTO
	{	
		/// <summary>
		/// ИД. точки маршрута.
		/// </summary>
		public Guid RoutePointId { get; set; }

		/// <summary>
		/// DTO для геолокации.
		/// </summary>
		public GeoPointDTO GeoPoint { get; set; }		

		/// <summary>
		/// Порядок точки маршрута.
		/// </summary>
		public int OrderIndex { get; set; }
	}
}
