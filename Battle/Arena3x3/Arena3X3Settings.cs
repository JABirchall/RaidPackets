
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Configuration;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class Arena3X3Settings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public bool EnabledArena3X3Shop;
		[Json]
		// [Key]
		public ConfigDateTime StartTime;
		[Json]
		// [Key]
		public double RefreshLeaguesTimeoutInHours;
		[Json]
		// [Key]
		public int RefreshPriceGems;
		[Json]
		// [Key]
		public int OpponentFreeRefreshTimeSec;
		[Json]
		// [Key]
		public int StartPriceTokens;
		[Json]
		// [Key]
		public int MidOpponentGroupSize;
		[Json]
		// [Key]
		public int LowOpponentGroupSize;
		[Json]
		// [Key]
		public int TopOpponentGroupSize;
		[Json]
		// [Key]
		public int RequiredLevel;
		[Json]
		// [Key]
		public double UpdateLeagueBordersDelaySeconds;
		[Json]
		// [Key]
		public int BattleLogLength;
		[Json]
		// [Key]
		public double RefillItemInboxLifetimeDays;
		[Json]
		// [Key]
		public double StoreOldStatusesDelayHours;
		[Json]
		// [Key]
		public bool LeagueRewardEnabled;
		[Json]
		// [Key]
		public Arena3X3LeaguesInfo LeaguesInfo;
		[Json]
		// [Key]
		public int MaxDailyFreeTokens;
		[Json]
		// [Key]
		public bool RefreshOpponentsImproved;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int TotalOpponentsCount { get => default; }
	
		// Constructors
		public Arena3X3Settings() {}
	}
}
