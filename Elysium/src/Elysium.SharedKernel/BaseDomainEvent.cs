﻿using MediatR;
using System;

namespace Elysium.SharedKernel
{
	public abstract class BaseDomainEvent : INotification
	{
		public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
	}
}