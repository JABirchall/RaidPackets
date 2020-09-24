
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
	public class NotificationsSettings
	{
		// Fields
		[Json]
		// [Key]
		public int AttachmentVersion;
		[Json]
		// [Key]
		public string AttachmentUrl;
		[Json]
		// [Key]
		public int[] ChurnNotificationIntervalsInMinutes;
		[Json]
		// [Key]
		public int SendChurnNotificationTime;
		[Json]
		// [Key]
		public double RequestPermissionDelay;
		[Json]
		// [Key]
		public double AllianceBossHealthLeftInPercent;
		[Json]
		// [Key]
		public int? NotificationsMinGapInSeconds;
		[Json]
		// [Key]
		public ChurnNotificationsAbTest ChurnNotificationsAbTest;
		[Json]
		// [Key]
		public ReworkNotificationSettings ReworkNotificationSettings;
	
		// Constructors
		public NotificationsSettings() {}
	}
}
