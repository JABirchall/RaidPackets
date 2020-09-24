
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Dtos
{
	[MessagePackObject]
	public class GlobalEventsRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public DateTime UpdateTime;
		[Json]
		// [Key]
		public List<int> KnownEventIds;
	
		// Constructors
		public GlobalEventsRequestDto() {}
		public GlobalEventsRequestDto(DateTime updateTime, List<int> knownEventsIds) {}
	}
}
