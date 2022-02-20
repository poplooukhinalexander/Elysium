namespace Elysium.Web.ApiModels
{
	public class SearchParameterDTO
	{
		/// <summary>
		/// Текущий номер страницы поиска.
		/// </summary>
		public int PageNumber { get; set; } = 1;

		/// <summary>
		/// Кол-во найденых записей на странице.
		/// </summary>
		public int PageSize { get; set; } = 10;
	}
}
