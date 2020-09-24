
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.DailyUpdates.Entities
{
	[MessagePackObject]
	public class DailyUpdateType
	{
		// Fields
		[Json]
		// [Key]
		public DailyUpdateTypeId Id;
		[Json]
		// [Key]
		public int PeriodDays;
	
		// Constructors
		public DailyUpdateType() {}
		public DailyUpdateType(DailyUpdateTypeId id, int periodDays = 1) {}
	}
}
