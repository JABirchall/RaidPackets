
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



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	// [RemovedJson]
	public class StaticArenaData
	{
		// Fields
		[Json]
		// [Key]
		public List<ArenaLeagueInfo> LeagueInfos;
		[Json]
		// [Key]
		public Account.Resources RefreshPrice;
		[Json]
		// [Key]
		public Account.Resources StartPrice;
		[Json]
		// [Key]
		public int MaxDailyRatedDefeats;
		[Json]
		// [Key]
		public int EnemyListLength;
		[Json]
		// [Key]
		public int OpponentFreeRefreshTimeSec;
		[Json]
		// [Key]
		public int PlatinumLeagueCapacity;
		[Json]
		// [Key]
		public int MaxDailyFreeTokens;
		[Json]
		// [Key]
		public int FreeTokensPerHour;
		[Json]
		// [Key]
		public int HeroSlotsCount;
		[Json]
		// [Key]
		public int OpponentRefreshPriceGems;
		[Json]
		// [Key]
		public int MinArenaPoints;
		[Json]
		// [Key]
		public int MaxArenaPoints;
		[Json]
		// [Key]
		public bool PlatinumLeagueEnabled;
		[Json]
		// [Key]
		public int PlatinumLeagueSameOpponentCooldownSeconds;
		[Json]
		// [Key]
		public int PlatinumLeagueSameOpponentCooldownBattles;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArenaLeagueId, ArenaLeagueInfo> LeagueInfoById;
	
		// Constructors
		public StaticArenaData() {}
	
		// Methods
		public void Cache() {}
	}
}
