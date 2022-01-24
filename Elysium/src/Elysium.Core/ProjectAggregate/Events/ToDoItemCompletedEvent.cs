using Elysium.Core.ProjectAggregate;
using Elysium.SharedKernel;

namespace Elysium.Core.ProjectAggregate.Events
{
	public class ToDoItemCompletedEvent : BaseDomainEvent
	{
		public ToDoItem CompletedItem { get; set; }

		public ToDoItemCompletedEvent(ToDoItem completedItem)
		{
			CompletedItem = completedItem;
		}
	}
}