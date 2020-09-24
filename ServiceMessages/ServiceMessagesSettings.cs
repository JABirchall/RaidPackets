
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.ServiceMessages
{
	[MessagePackObject]
	public class ServiceMessagesSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int ShrinkCount;
		[Json]
		// [Key]
		public int? StorageLimit;
		[Json]
		// [Key]
		public int[] RestartNotificationMinutes;
	
		// Constructors
		public ServiceMessagesSettings() {}
	}
}
