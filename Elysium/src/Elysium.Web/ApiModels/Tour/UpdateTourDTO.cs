using System;

namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// DTO для обновления машрута
	/// </summary>
	public class UpdateTourDTO : CreateTourDTO
	{
		/// <summary>
		/// ИД обновляемого тура.
		/// </summary>
		public Guid TourId { get; set; }		
	}
}
