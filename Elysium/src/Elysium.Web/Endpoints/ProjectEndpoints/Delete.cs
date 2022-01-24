﻿using Ardalis.ApiEndpoints;
using Elysium.Core.ProjectAggregate;
using Elysium.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace Elysium.Web.Endpoints.ProjectEndpoints
{
	public class Delete : BaseAsyncEndpoint
		.WithRequest<DeleteProjectRequest>
		.WithoutResponse
	{
		private readonly IRepository<Project> _repository;

		public Delete(IRepository<Project> repository)
		{
			_repository = repository;
		}

		[HttpDelete(DeleteProjectRequest.Route)]
		[SwaggerOperation(
			Summary = "Deletes a Project",
			Description = "Deletes a Project",
			OperationId = "Projects.Delete",
			Tags = new[] { "ProjectEndpoints" })
		]
		public override async Task<ActionResult> HandleAsync([FromRoute] DeleteProjectRequest request,
			CancellationToken cancellationToken)
		{
			var aggregateToDelete = await _repository.GetByIdAsync(request.ProjectId); // TODO: pass cancellation token
			if (aggregateToDelete == null) return NotFound();

			await _repository.DeleteAsync(aggregateToDelete);

			return NoContent();
		}
	}
}
