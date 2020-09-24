
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Logging;
using SharedModel.Meta.DailyUpdates.Entities;



namespace SharedModel.Meta.DailyUpdates
{
	[MessagePackObject]
	public class StaticDailyUpdateData
	{
		// Fields
		private static readonly ISharedLog Log;
		[Json]
		// [Key]
		public List<DailyUpdateType> Types;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<DailyUpdateTypeId, DailyUpdateType> _types;
	
		// Constructors
		public StaticDailyUpdateData() {}
		static StaticDailyUpdateData() {}
	
		// Methods
		public void Cache() {}
		public DailyUpdateType GetType(DailyUpdateTypeId typeId) => default;
	}
}
