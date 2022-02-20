using System;

namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// Базоввый DTO для тура.
	/// </summary>
	public class BaseTourDTO
	{
		/// <summary>
		/// Нзавание тура.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание тура.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Дата начала тура.
		/// </summary>
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Дата окончания тура.
		/// </summary>
		public DateTime EndDate { get; set; }
	}
}
