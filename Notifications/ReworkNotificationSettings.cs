
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class ReworkNotificationSettings
	{
		// Fields
		[Json]
		// [Key]
		public NotificationsInterval[] NotificationsIntervals;
		[Json]
		// [Key]
		public ReturningPlayerSettings ReturningPlayerSettings;
	
		// Constructors
		public ReworkNotificationSettings() {}
	}
}
