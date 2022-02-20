using System.Collections.Generic;


namespace Elysium.Web.ApiModels
{
	public class SearchResultDTO<T>
	{
		/// <summary>
		/// Кол-во страниц с результатами поиска.
		/// </summary>
		public int TotalPageNumber { get; set; }

		/// <summary>
		/// Номер текущей страницы.
		/// </summary>
		public int CurrentPageNumber { get; set; }

		/// <summary>
		/// Кол-во записей на странице.
		/// </summary>
		public int CurrentPageSize { get; set; }

		/// <summary>
		/// Коллекция найденных туров.
		/// </summary>
		public IEnumerable<T> Tours { get; set; }
	}
}
