
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Notifications.Enums;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class ScheduledPushNotification
	{
		// Fields
		[Json]
		// [Key]
		public Guid Id;
		[Json]
		// [Key]
		public DateTime ScheduledTime;
		[Json]
		// [Key]
		public NotificationTypeId Type;
		[Json]
		// [Key]
		public PushCancellationDetails CalcellationDetails;
	
		// Constructors
		public ScheduledPushNotification() {}
	}
}
