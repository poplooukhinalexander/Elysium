using Elysium.Core.ProjectAggregate;
using System.Collections.Generic;

namespace Elysium.Web.Endpoints.ProjectEndpoints
{
	public class ProjectListResponse
	{
		public List<ProjectRecord> Projects { get; set; } = new();
	}
}
