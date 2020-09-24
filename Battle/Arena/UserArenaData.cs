
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Battle;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class UserArenaData
	{
		// Fields
		[Json]
		// [Key]
		public long ArenaPoints;
		[Json]
		// [Key]
		public List<ArenaOpponent> Opponents;
		[Json]
		// [Key]
		public List<ArenaLog> Logs;
		[Json]
		// [Key]
		public DateTime LastListRefreshTime;
		[Json]
		// [Key]
		public DateTime LastParticipationTime;
		[Json]
		// [Key]
		public DateTime LastDefeatTime;
		[Json]
		// [Key]
		public int DefeatTimesToday;
		[Json]
		// [Key]
		public DateTime LastWeeklyRewardTime;
		[Json]
		// [Key]
		public DateTime LastRegularProcessTime;
		[Json]
		// [Key]
		public UserPrize LastWeeklyReward;
		[Json]
		// [Key]
		public ArenaLeagueId LastWeeklyRewardLeagueId;
		[Json]
		// [Key]
		public ArenaLeagueId LastButOneWeeklyRewardLeagueId;
		[Json]
		// [Key]
		public int BattlesStartedThisWeek;
		[Json]
		// [Key]
		public int[] DefenseHeroIds;
		[Json]
		// [Key]
		public double LastPointsAdded;
		[Json]
		// [Key]
		public ArenaOpponent CurrentOpponent;
		[Json]
		// [Key]
		public long? PlatinumLeagueStatusId;
		[Json]
		// [Key]
		public int FirstPlaceInPlatinumTimes;
		[Json]
		// [Key]
		public int? LastPlaceInPlatinum;
		[Json]
		// [Key]
		public UserArenaShortBattleStats BattleStats;
		[Json]
		// [Key]
		public List<ArenaOpponentBonusData> OpponentBonuses;
		[Json]
		// [Key]
		public int PointsDeltaInPlatinumToday;
	
		// Constructors
		public UserArenaData() {}
	
		// Methods
		public UserArenaData CloneForLogging() => default;
	}
}
