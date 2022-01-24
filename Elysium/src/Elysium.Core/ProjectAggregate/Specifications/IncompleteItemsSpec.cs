using Ardalis.Specification;

namespace Elysium.Core.ProjectAggregate.Specifications
{
	public class IncompleteItemsSpec : Specification<ToDoItem>
	{
		public IncompleteItemsSpec()
		{
			Query.Where(item => !item.IsDone);
		}
	}
}
