
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Battle.Arena3x3;



namespace SharedModel.Meta.Battle.Arena.Dtos
{
	[MessagePackObject]
	public class StaticArena3X3Data : StaticArenaData
	{
		// Fields
		[Json]
		// [Key]
		public List<StaticArena3x3ShopItemData> ShopItems;
		[Json]
		// [Key]
		public Arena3X3Settings Settings;
		[Json]
		// [Key]
		public int BattlesInARow;
		[Json]
		// [Key]
		public Dictionary<ArenaLeagueId, ArenaLeagueGroupBoundariesInfo> GroupBoundaryLimitsByLeagueId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int HeroSlotsCountPerRound { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool Enabled { get => default; }
	
		// Constructors
		public StaticArena3X3Data() {}
	
		// Methods
		public ArenaLeagueGroupBoundariesInfo GetBoundariesForCacheSize(ArenaLeagueId leagueId, int cacheSize) => default;
	}
}
