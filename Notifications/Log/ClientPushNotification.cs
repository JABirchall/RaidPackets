
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Notifications.Enums;



namespace SharedModel.Meta.Notifications.Log
{
	[MessagePackObject]
	public class ClientPushNotification
	{
		// Fields
		[Json]
		// [Key]
		public NotificationTypeId TypeId;
		[Json]
		// [Key]
		public DateTime? ReceivingTimeLocal;
		[Json]
		// [Key]
		public DateTime? ReceivingTimeUtc;
		[Json]
		// [Key]
		public ClientPushNotificationActionType ActionType;
		[Json]
		// [Key]
		public PushNotificationPayload Payload;
		[Json]
		// [Key]
		public PayloadType? PayloadType;
	
		// Constructors
		public ClientPushNotification() {}
	}
}
