
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
	public class NotificationSettingsGroupData
	{
		// Fields
		[Json]
		// [Key]
		public List<NotificationTypeId> NotificationTypes;
		[Json]
		// [Key]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		public long Revision;
	
		// Constructors
		public NotificationSettingsGroupData() {}
	
		// Methods
		public NotificationSettingsGroupData SetRevision(long rev) => default;
		public NotificationSettingsGroupData SetName(string key, string name) => default;
		public NotificationSettingsGroupData Add(NotificationTypeId notificationType) => default;
	}
}
