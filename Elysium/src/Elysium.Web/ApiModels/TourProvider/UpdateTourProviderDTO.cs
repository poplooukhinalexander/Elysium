using System;

namespace Elysium.Web.ApiModels.TourProvider
{
	public class UpdateTourProviderDTO : CreateTourProviderDTO
	{		
		public Guid TourProviderId { get; set; }
	}
}
