
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
	public class PushNotificationPayload
	{
		// Fields
		[Json]
		// [Key]
		public NotificationTypeId TypeId;
		[Json]
		// [Key]
		public DateTime? DateTime;
		[Json]
		// [Key]
		public int? GroupId;
		[Json]
		// [Key]
		public int? CampaignRevisionId;
		[Json]
		// [Key]
		public int? CampaignRunId;
		[Json]
		// [Key]
		public int? CampaignId;
		[Json]
		// [Key]
		public char? GroupLabel;
	
		// Constructors
		public PushNotificationPayload() {}
	}
}
