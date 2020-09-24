
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
	public class ChurnNotificationSettings
	{
		// Fields
		[Json]
		// [Key]
		public int ScheduleTimeInHours;
		[Json]
		// [Key]
		public int[] IntervalsInMinutes;
	
		// Constructors
		public ChurnNotificationSettings() {}
	}
}
