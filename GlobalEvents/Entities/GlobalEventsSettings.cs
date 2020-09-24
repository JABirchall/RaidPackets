
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.FeatureStatuses;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventsSettings
	{
		// Fields
		[Json]
		// [Key]
		public FeatureStatus Status;
		[Json]
		// [Key]
		public string UrlFormat;
	
		// Constructors
		public GlobalEventsSettings() {}
	}
}
