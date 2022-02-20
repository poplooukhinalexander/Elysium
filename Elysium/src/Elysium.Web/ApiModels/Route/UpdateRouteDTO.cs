using System;


namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// DTO для обнвления информации о маршруте.
	/// </summary>
	public class UpdateRouteDTO : BaseRouteDTO
	{
		/// <summary>
		/// ИД. обновляемой сущности
		/// </summary>
		public Guid RouteId { get; set; }		
	}
}
