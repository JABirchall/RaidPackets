
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.DailyRewards.Data;



namespace SharedModel.Meta.LoyaltyProgram.Data
{
	[MessagePackObject]
	public class DailyRewardProgramSettings
	{
		// Fields
		[Json]
		// [Key]
		public DailyRewardProgramType Type;
		[Json]
		// [Key]
		public int RewardHeroTypeId;
	
		// Constructors
		public DailyRewardProgramSettings() {}
		public DailyRewardProgramSettings(DailyRewardProgramType type, int rewardHeroTypeId) {}
	}
}
