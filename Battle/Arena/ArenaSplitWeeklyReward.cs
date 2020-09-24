
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Stages;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class ArenaSplitWeeklyReward : IArenaSplitWeeklyReward
	{
		// Properties
		[Json]
		// [Key]
		public List<UserPrize> FixedPrizes { get; set; }
		[Json]
		// [Key]
		public FlexibleReward FlexibleReward { get; set; }
	
		// Constructors
		public ArenaSplitWeeklyReward() {}
	}
}
