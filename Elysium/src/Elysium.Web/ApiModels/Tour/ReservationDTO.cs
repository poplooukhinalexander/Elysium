using System;

namespace Elysium.Web.ApiModels.Tour
{
	public class ReservationDTO
	{
		/// <summary>
		/// ИД. бронирующего тур.
		/// </summary>
		public Guid UserId { get; set; }		

		/// <summary>
		/// Кол-во билетов.
		/// </summary>
		public int TicketNum { get; set; }
	}
}
