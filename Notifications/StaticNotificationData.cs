
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Localization;
using SharedModel.Meta.Notifications.Enums;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class StaticNotificationData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<NotificationSettingsGroup, NotificationSettingsGroupData> Settings;
		[Json]
		// [Key]
		public List<NotificationTypeId> DisabledTypeIds;
		[Json]
		// [Key]
		public Dictionary<NotificationTypeId, SharedLTextKey> Messages;
	
		// Constructors
		public StaticNotificationData() {}
	
		// Methods
		public void Add(NotificationSettingsGroup settingsGroup, NotificationSettingsGroupData settings) {}
		public StaticNotificationData Off(NotificationTypeId typeId) => default;
		public bool IsOff(NotificationTypeId typeId) => default;
		public List<NotificationTypeId> GetGroupNotifications(NotificationSettingsGroup group) => default;
	}
}
