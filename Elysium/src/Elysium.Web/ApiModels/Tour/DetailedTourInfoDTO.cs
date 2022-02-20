using System;
using System.Collections.Generic;

namespace Elysium.Web.ApiModels.Tour
{
	/// <summary>
	/// DTO для представления маршрута.
	/// </summary>
	public class DetailedTourInfoDTO : BaseTourDTO
	{		
		/// <summary>
		/// ИД. тура.
		/// </summary>
		public Guid TourId { get; set; }
		/// <summary>
		/// Маршрут тура. ?expand=routePhoto - загрузить ссылки на фото вместе с маршрутом.
		/// </summary>
		public Route.RouteDTO Route { get; set; }			

		/// <summary>
		/// Попутчики в туре, загружаются по ?expand=Companions
		/// </summary>
		public IEnumerable<UserProfile.UserProfileDTO> Companions { get; set; }		
		
		/// <summary>
		/// Тур-оператор. Зашружается по ?expand=TourProvider
		/// </summary>
		public TourProvider.TourProviderDTO TourProvider { get; set; }

		/// <summary>
		/// Отзывы о пред.турах. Загружается по ?expand=Feedbacks
		/// </summary>
		public IEnumerable<Feedback.FeedbackDTO> Feedbacks { get; set; }

		/// <summary>
		/// Всего билетов.
		/// </summary>
		public int TotalTicketNumber { get; set; }

		/// <summary>
		/// Кол-во зарезервированных билетов.
		/// </summary>
		public int ReservedTicketNumber { get; set; }
	}
}
