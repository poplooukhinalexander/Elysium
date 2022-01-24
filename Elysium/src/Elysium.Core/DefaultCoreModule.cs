using Autofac;
using Elysium.Core.Interfaces;
using Elysium.Core.Services;

namespace Elysium.Core
{
	public class DefaultCoreModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<ToDoItemSearchService>()
				.As<IToDoItemSearchService>().InstancePerLifetimeScope();
		}
	}
}
