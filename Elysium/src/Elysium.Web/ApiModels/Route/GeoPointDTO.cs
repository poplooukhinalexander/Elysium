namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для геолокации.
	/// </summary>
	public class GeoPointDTO
	{
		/// <summary>
		/// Долгота.
		/// </summary>
		public decimal Longitude { get; set; }

		/// <summary>
		/// Широта.
		/// </summary>
		public decimal Latitude { get; set; }
	}
}
