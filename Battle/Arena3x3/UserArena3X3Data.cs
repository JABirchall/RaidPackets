
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class UserArena3X3Data : UserArenaData
	{
		// Fields
		[Json]
		// [Key]
		public ArenaLeagueId LeagueId;
		[Json]
		// [Key]
		public DateTime LastRatingUpdateTime;
		[Json]
		// [Key]
		public long? RatingStatusId;
		[Json]
		// [Key]
		public int[] CurrentTeamSetupHeroes;
		[Json]
		// [Key]
		public UserPrize AvailableLeagueReward;
		[Json]
		// [Key]
		public int BattleIndex;
		[Json]
		// [Key]
		public long? CurrentStartPoints;
		[Json]
		// [Key]
		public List<long> CurrentGainedPoints;
		[Json]
		// [Key]
		public List<long> CurrentOpponentPoints;
		[Json]
		// [Key]
		public ArenaLeagueId? CurrentStartLeagueId;
		[Json]
		// [Key]
		public List<UserArena3x3ShopItemData> BoughtItems;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsTransitionalBattle { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsFirstBattleInARow { get => default; }
	
		// Constructors
		public UserArena3X3Data() {}
	
		// Methods
		public new UserArena3X3Data CloneForLogging() => default;
	}
}
