namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для добавления новой точки маршрута.
	/// </summary>
	public class CreateRoutePointDTO
	{		
		/// <summary>
		/// Название геолокации.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Описание геолокации.
		/// </summary>
		public string Description { get; set; }			
	}
}
