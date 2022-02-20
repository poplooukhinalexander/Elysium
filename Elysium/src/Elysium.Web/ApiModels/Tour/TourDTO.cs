using System;


namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// DTO для туру.
	/// </summary>
	public class TourDTO : BaseTourDTO
	{
		/// <summary>
		/// ИД. тура.
		/// </summary>
		public Guid TourId { get; set; }

		/// <summary>
		/// Провайдер тура.
		/// </summary>
		public TourProvider.TourProviderDTO TourProvider { get; set; }
	}
}
