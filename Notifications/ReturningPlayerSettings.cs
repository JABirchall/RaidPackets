
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class ReturningPlayerSettings
	{
		// Fields
		[Json]
		// [Key]
		public int PeriodInDays;
		[Json]
		// [Key]
		public int NewUsersDelayInDays;
		[Json]
		// [Key]
		public Dictionary<int, int> NotificationsTime;
	
		// Constructors
		public ReturningPlayerSettings() {}
	}
}
