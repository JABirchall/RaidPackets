
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class UserArenaShortBattleStats
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<long, UserArenaBattleStatsWithOpponent> StatsByOpponent;
		[Json]
		// [Key]
		public DateTime LastStatsRefreshTime;
	
		// Constructors
		public UserArenaShortBattleStats() {}
		public UserArenaShortBattleStats(DateTime now) {}
	
		// Methods
		public void AddOrUpdateStats(long opponentUserId, DateTime now) {}
		public void RefreshIfNeeded(DateTime now) {}
	}
}
