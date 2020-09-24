
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Notifications
{
	[MessagePackObject]
	public class ChurnNotificationsAbTest
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public Dictionary<int, ChurnNotificationSettings> AbGroups;
	
		// Constructors
		public ChurnNotificationsAbTest() {}
	}
}
