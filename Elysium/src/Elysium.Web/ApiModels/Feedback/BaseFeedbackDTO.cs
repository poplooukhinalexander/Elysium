using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elysium.Web.ApiModels.Feedback
{
	/// <summary>
	/// Базовый DTO для отзыва о туре.
	/// </summary>
	public class BaseFeedbackDTO
	{
		/// <summary>
		/// Комментарий.
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// Оценка.
		/// </summary>
		public EstimationLevel Estimation { get; set; }
	}
}
