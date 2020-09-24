
using System;
using System.Collections.Generic;
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
	public class UserNotificationData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<NotificationSettingsGroup, NotificationState> NotificationSettings;
		[Json]
		// [Key]
		public Dictionary<NotificationSettingsGroup, long> Revisions;
		[Json]
		// [Key]
		public Dictionary<int, bool> InternalNotificationSettings;
		[Json]
		// [Key]
		public List<ScheduledPushNotification> ScheduledNotifications;
	
		// Constructors
		public UserNotificationData() {}
	
		// Methods
		public void UpdateSettings(Dictionary<NotificationSettingsGroup, NotificationState> settings) {}
		public void UpdateGroups() {}
		private void UpdateGroupSettings(NotificationSettingsGroup group, long revision) {}
		private bool IsGroupSettingsActual(NotificationSettingsGroup group, long revision) => default;
		public void InitRevisions() {}
		private void NormalizeNotifications(DateTime now) {}
		public List<ScheduledPushNotification> GetNormalizedNotifications(DateTime now) => default;
		public void AddScheduledNotification(ScheduledPushNotification notification, DateTime now) {}
	}
}
