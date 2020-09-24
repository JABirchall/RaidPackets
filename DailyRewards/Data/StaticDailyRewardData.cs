
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.LoyaltyProgram.Data;



namespace SharedModel.Meta.DailyRewards.Data
{
	[MessagePackObject]
	// [RemovedJson]
	public class StaticDailyRewardData
	{
		// Fields
		[Json]
		// [Key]
		public LoyaltyProgramSettings Settings;
		[Json]
		// [Key]
		public Dictionary<DailyRewardProgramType, List<DailyRewardProgramDay>> Programs;
	
		// Constructors
		public StaticDailyRewardData() {}
	}
}
