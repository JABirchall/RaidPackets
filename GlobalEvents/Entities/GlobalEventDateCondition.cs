
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventDateCondition
	{
		// Fields
		[Json]
		// [Key]
		public DateTime? TeaserStart;
		[Json]
		// [Key]
		public DateTime? Start;
		[Json]
		// [Key]
		public DateTime? End;
		[Json]
		// [Key]
		public DateTime? TakePrizeDeadline;
		[Json]
		// [Key]
		public TimeSpan? BracketDuration;
		[Json]
		// [Key]
		public TimeSpan? RewardDuration;
	
		// Constructors
		public GlobalEventDateCondition() {}
	
		// Methods
		public bool IsRunning() => default;
		public bool IsTeaserPeriod() => default;
		public string ToStringExt() => default;
	}
}
