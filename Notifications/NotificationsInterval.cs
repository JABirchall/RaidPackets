
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class NotificationsInterval
	{
		// Fields
		[Json]
		// [Key]
		public int StartTime;
		[Json]
		// [Key]
		public int FinishTime;
	
		// Constructors
		public NotificationsInterval() {}
	}
}
