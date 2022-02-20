namespace Elysium.Web.ApiModels.Route
{
	/// <summary>
	/// Базовый DTO для маршрута.
	/// </summary>
	public class BaseRouteDTO
	{
		/// <summary>
		/// Название маршурта.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание тура.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Сложность маршрута.
		/// </summary>
		public RouteDifficultLevel DifficultLevel { get; set; }
	}
}
