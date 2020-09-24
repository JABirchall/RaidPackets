
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Account;
using SharedModel.Meta.Alliances.Boss;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	// [RemovedJson]
	public class StaticAllianceData
	{
		// Fields
		[Json]
		// [Key]
		public AllianceSettings Settings;
		[Json]
		// [Key]
		public List<AllianceAchievementType> AchievementTypes;
		[Json]
		// [Key]
		public List<AllianceBossType> BossTypes;
		[Json]
		// [Key]
		public List<AllianceBossReward> BossRewards;
		[Json]
		// [Key]
		public List<AllianceBossRewardRange> BossRewardConditions;
		[Json]
		// [Key]
		public Account.Resources BossBattleStartPrice;
		[Json]
		// [Key]
		public TimeSpan BossRefreshTime;
		[Json]
		// [Key]
		public int BossBattleHeroSlotsCount;
		[Json]
		// [Key]
		public List<FlexibleReward> ActivityRewards;
		[Json]
		// [Key]
		public int RemindLevel;
		[Json]
		// [Key]
		public List<int> BossHeroTypeIds;
	
		// Constructors
		public StaticAllianceData() {}
	
		// Methods
		public AllianceAchievementType GetAchievementType(AllianceAchievementTypeId typeId) => default;
		public AllianceBossType GetBossType(AllianceBossTypeId id) => default;
		public DateTime GetActivityDate(DateTime time) => default;
		public AllianceBossDamageDealtRange GetBossRewardRange(AllianceBoss boss, double dealtDamage) => default;
	}
}
