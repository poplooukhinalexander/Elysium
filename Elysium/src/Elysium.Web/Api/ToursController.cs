using System;
using System.Threading.Tasks;
using System.Web.Http.Description;

using Microsoft.AspNetCore.Mvc;


namespace Elysium.Web.Api
{
	using ApiModels;
	using ApiModels.Feedback;
	using ApiModels.Tour;
	using ApiModels.UserProfile;


	public class ToursController : BaseApiController
	{
		/// <summary>
		/// Поиск тура по параметрам поиска.
		/// </summary>
		/// <param name="tourSearchParameters">Параметры поиска тура.</param>
		/// <returns>Результат поиска.</returns>
		/// <response code="200">OK.</response>
		/// <response code="400">Невалидные параметры.</response>
		/// <response code="404">Not Found.</response>
		[HttpGet("/search")]		
		[ResponseType(typeof(TourSearchResultDTO))]		
		public async Task<IActionResult> FindTours([FromQuery] TourSearchParametersDTO tourSearchParameters)
		{
			return await Task.Run(() => Ok(new TourSearchResultDTO()));			
		}	
		
		/// <summary>
		/// Забронировать участие в туре.
		/// </summary>
		/// <param name="tourId">ИД. тура.</param>
		/// <param name="reservation">DTO с информацией о резервации тура.</param>
		/// <returns></returns>
		/// <response code="200">OK.</response>
		/// <response code="400">Неудача в резервировании тура.</response>
		/// <response code="404">Тур не найден.</response>
		[HttpPost("{tourId:Guid}/reserve")]
		public async Task<IActionResult> ReserveTickets(Guid tourId, [FromBody] ReservationDTO reservation)
		{
			return await Task.Run(() => Ok());
		}

		/// <summary>
		/// Возвращает детальную информацию о туре.
		/// </summary>
		/// <param name="tourId">ИД. тура.</param>
		/// <param name="expandParams">?expand=Companions&expand=TourProvider&expand=Feedbacks</param>
		/// <returns>Объект типа <see href="DetailedTourInfoDTO">DetailedTourInfoDTO</see></returns>
		/// <response code="200">OK.</response>
		/// <response code="404">Not found.</response>
		[HttpGet("{tourId:Guid}")]
		[ResponseType(typeof(DetailedTourInfoDTO))]
		public async Task<IActionResult> GetTourDetailedInfo(Guid tourId, [FromQuery] string[] expandParams)
		{
			return await Task.Run(() => Ok(new DetailedTourInfoDTO()));
		}

		/// <summary>
		/// Возвращает постранично список попутчиков.
		/// </summary>
		/// <param name="tourId">ИД. тура</param>
		/// <param name="searchParameter">DTO с параметрами поиска попутчиков.</param>
		/// <returns>Постраничный список попутчиков.</returns>
		/// <response code="200">OK.</response>
		/// <response code="400">Невалидный параметр поиска.</response>
		/// <response code="404">Попутчики не найдены.</response>
		[HttpGet("{tourId:Guid}/companions")]
		[ResponseType(typeof(SearchResultDTO<UserProfileDTO>))]
		public async Task<IActionResult> GetCompanions(Guid tourId, [FromQuery] SearchParameterDTO searchParameter)
		{
			return await Task.Run(() => Ok(new SearchResultDTO<UserProfileDTO>()));
		}

		/// <summary>
		/// Возвращает постранично отзывы о предыдущих турах.
		/// </summary>
		/// <param name="tourId">ИД. тура.</param>
		/// <param name="searchParameters">DTO с параметрами поиска отзывов.</param>
		/// <returns>Постраничный список отзывов.</returns>
		/// <response code="200">OK.</response>
		/// <response code="400">Невалидные параметры поиска.</response>
		/// <response code="404">Данные не найдены.</response>
		[HttpGet("{tourId:Guid}/feedbacks")]
		[ResponseType(typeof(SearchResultDTO<FeedbackDTO>))]
		public async Task<IActionResult> GetFeedbacks(Guid tourId, [FromQuery] SearchFeedbackParametersDTO searchParameters)
		{
			return await Task.Run(() => Ok(new SearchResultDTO<FeedbackDTO>()));
		}
	}
}
