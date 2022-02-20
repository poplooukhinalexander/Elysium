using System;


namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// DTO с параметрами для поиска туров.
	/// </summary>
	public class TourSearchParametersDTO : SearchParameterDTO
	{		

		/// <summary>
		/// Нзавание локации тура.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Дата начала тура.
		/// </summary>
		public DateTime? StartPeriod { get; set; }

		/// <summary>
		/// Дата окночания тура.
		/// </summary>
		public DateTime EndPeriod { get; set; }
	}
}
