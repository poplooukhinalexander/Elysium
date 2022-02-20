namespace Elysium.Web.ApiModels.Feedback
{
	public class SearchFeedbackParametersDTO : SearchParameterDTO
	{
		/// <summary>
		/// Поиск по оценке. По умолчанию null.
		/// </summary>
		public EstimationLevel? EstimationLevel { get; set; }

		/// <summary>
		/// Порядок по оценке. 1 вначале плохие отзывы, потом хорошие. -1 Вначале хорошие, потому плохие. 0 - нет порядка. Порядок по дате.
		/// </summary>
		public int EstimationLevelOrder { get; set; } = 0;
	}
}
