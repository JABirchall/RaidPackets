
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
	public class DailyUpdate
	{
		// Fields
		[Json]
		// [Key]
		public DailyUpdateTypeId TypeId;
		[Json]
		// [Key]
		public DateTime? Time;
		[IgnoreMember]
		[JsonSkip]
		private DailyUpdateType _type;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public DateTime NextUpdateDate { get => default; }
		[IgnoreMember]
		[JsonSkip]
		private DailyUpdateType Type { get => default; }
	
		// Constructors
		public DailyUpdate() {}
	
		// Methods
		public bool IsReady(DateTime now) => default;
	}
}
