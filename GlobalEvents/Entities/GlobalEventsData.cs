
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventsData
	{
		// Fields
		[Json]
		// [Key]
		public int LastEventId;
		[Json]
		// [Key]
		public DateTime UpdateTime;
		[Json]
		// [Key]
		public List<GlobalEvent> Events;
	
		// Constructors
		public GlobalEventsData() {}
		public GlobalEventsData(DateTime updateTime, List<GlobalEvent> events) {}
	}
}
