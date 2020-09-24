
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.AbTests
{
	[MessagePackObject]
	public class AbTestType
	{
		// Fields
		[Json]
		// [Key]
		public AbTestTypeId Id;
		[Json]
		// [Key]
		public DateTime StartTime;
		[Json]
		// [Key]
		public DateTime? EndTime;
		[Json]
		// [Key]
		public Dictionary<AbTestGroupId, double> ProbabilityByGroupId;
		[Json]
		// [Key]
		public Dictionary<AbTestGroupId, List<ShardImproveInfo>> SummonImproveByGroupId;
		[Json]
		// [Key]
		public Dictionary<AbTestGroupId, UserPrize> BonusesByGroupId;
		[Json]
		// [Key]
		public Dictionary<AbTestGroupId, int> UserLevelByGroupId;
		[Json]
		// [Key]
		public bool Delayed;
	
		// Constructors
		public AbTestType() {}
	}
}
