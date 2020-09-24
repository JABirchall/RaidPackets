
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Notifications.Log
{
	[MessagePackObject]
	public class LogNotificationsDto
	{
		// Fields
		[Json]
		// [Key]
		public List<ClientPushNotification> Notifications;
	
		// Constructors
		public LogNotificationsDto() {}
		public LogNotificationsDto(ClientPushNotification notification) {}
		public LogNotificationsDto(List<ClientPushNotification> notifications) {}
	}
}
