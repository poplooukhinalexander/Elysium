﻿using Elysium.Core.Interfaces;
using Elysium.Core.ProjectAggregate;
using Elysium.Core.ProjectAggregate.Events;
using Elysium.Core.ProjectAggregate.Handlers;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Elysium.UnitTests.Core.Handlers
{
	public class ItemCompletedEmailNotificationHandlerHandle
	{
		private ItemCompletedEmailNotificationHandler _handler;
		private Mock<IEmailSender> _emailSenderMock;

		public ItemCompletedEmailNotificationHandlerHandle()
		{
			_emailSenderMock = new Mock<IEmailSender>();
			_handler = new ItemCompletedEmailNotificationHandler(_emailSenderMock.Object);
		}

		[Fact]
		public async Task ThrowsExceptionGivenNullEventArgument()
		{
			Exception ex = await Assert.ThrowsAsync<ArgumentNullException>(() => _handler.Handle(null, CancellationToken.None));
		}

		[Fact]
		public async Task SendsEmailGivenEventInstance()
		{
			await _handler.Handle(new ToDoItemCompletedEvent(new ToDoItem()), CancellationToken.None);

			_emailSenderMock.Verify(sender => sender.SendEmailAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
		}
	}
}
