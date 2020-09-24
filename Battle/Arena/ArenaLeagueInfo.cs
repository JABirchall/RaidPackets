
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Stages;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	// [RemovedJson]
	public class ArenaLeagueInfo
	{
		// Fields
		[Json]
		// [Key]
		public ArenaLeagueId Id;
		[Json]
		// [Key]
		public int MinPoints;
		[Json]
		// [Key]
		public BattleStats BattleBonuses;
		[Json]
		// [Key]
		public UserPrize Reward;
		[Json]
		// [Key]
		public FlexibleReward FlexibleReward;
		[Json]
		// [Key]
		public FlexibleReward RegularFlexibleReward;
		[Json]
		// [Key]
		public UserPrize RegularRigidReward;
		[Json]
		// [Key]
		public int? Capacity;
		[Json]
		// [Key]
		public int? UpGoingCapacity;
		[Json]
		// [Key]
		public int? DownGoingCapacity;
		[Json]
		// [Key]
		public ArenaSplitWeeklyReward WeeklyFirstRewardsNew;
		[Json]
		// [Key]
		public ArenaSplitWeeklyReward WeeklySecondRewardsNew;
		[Json]
		// [Key]
		public ArenaSplitWeeklyReward WeeklyThirdRewardsNew;
		[Json]
		// [Key]
		public ArenaSplitWeeklyRewardOld WeeklyFirstRewardsOld;
		[Json]
		// [Key]
		public ArenaSplitWeeklyRewardOld WeeklySecondRewardsOld;
		[Json]
		// [Key]
		public ArenaSplitWeeklyRewardOld WeeklyThirdRewardsOld;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public IArenaSplitWeeklyReward WeeklyFirstRewards { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public IArenaSplitWeeklyReward WeeklySecondRewards { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public IArenaSplitWeeklyReward WeeklyThirdRewards { get => default; }
	
		// Constructors
		public ArenaLeagueInfo() {}
	}
}
