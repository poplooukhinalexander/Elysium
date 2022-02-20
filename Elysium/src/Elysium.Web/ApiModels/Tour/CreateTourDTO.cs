using System;

namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// DTO для создания тура.
	/// </summary>
	public class CreateTourDTO : BaseTourDTO
	{
		/// <summary>
		/// ИД. создаваемого маршрута.
		/// </summary>
		public Guid RouteId { get; set; }
	
		/// <summary>
		/// Количество мест в туре.
		/// </summary>
		public int TotalTicketNumber { get; set; }
	}
}
