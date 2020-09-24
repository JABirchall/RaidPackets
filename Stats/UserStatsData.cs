
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Result;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.MagicShop;
using SharedModel.Meta.Shards;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Stats
{
	[MessagePackObject]
	// [RemovedJson]
	public class UserStatsData
	{
		// Fields
		[Json]
		// [Key]
		public int InvitedUsers;
		[Json]
		// [Key]
		public int InviterBonuses;
		[Json]
		// [Key]
		public Dictionary<AreaTypeId, Dictionary<BattleResultType, int>> AutoBattleResultCountByArea;
		[Json]
		// [Key]
		public Dictionary<AreaTypeId, Dictionary<BattleResultType, int>> BattleResultCountByArea;
		[Json]
		// [Key]
		public Dictionary<ShardTypeId, Dictionary<HeroRarity, int>> SummonResultByShardId;
		[Json]
		// [Key]
		public Dictionary<MagicShopItemTypeId, int> BoughtItemsCountByTypeId;
		[Json]
		// [Key]
		public int ReachedTop10;
		[Json]
		// [Key]
		public int WonRating;
		[Json]
		// [Key]
		public int DailyQuestCompleted;
		[Json]
		// [Key]
		public string LastPaymentMethod;
		[Json]
		// [Key]
		public int PvPsOnRegDay;
		[Json]
		// [Key]
		public bool Played5MinsOnRegDay;
		[Json]
		// [Key]
		public bool Played10MinsOnRegDay;
		[Json]
		// [Key]
		public int SignInsOnRegistrationDay;
		[Json]
		// [Key]
		public int ArenaVictoriesDuringWeek;
		[Json]
		// [Key]
		public int ArenaDefeatsDuringWeek;
		[Json]
		// [Key]
		public int Arena3X3VictoriesDuringPeriod;
		[Json]
		// [Key]
		public int Arena3X3DefeatsDuringPeriod;
		[Json]
		// [Key]
		public ArenaLeagueId MaxArenaLeagueId;
		[Json]
		// [Key]
		public Dictionary<int, int> TrackerReasonCountById;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int StoryWinsCount { get => default; }
	
		// Constructors
		public UserStatsData() {}
	}
}
