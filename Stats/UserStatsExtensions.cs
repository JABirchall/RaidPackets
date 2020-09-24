
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Result;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.MagicShop;
using SharedModel.Meta.Shards;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Stats
{
	public static class UserStatsExtensions
	{
		// Extension methods
		public static UserStatsData AddBattleResult(this UserStatsData data, AreaTypeId areaId, BattleResultType resultType, bool isAutoBattle = false) => default;
		public static UserStatsData AddSummonResult(this UserStatsData data, ShardTypeId shardTypeId, HeroRarity heroRarity) => default;
		public static UserStatsData AddBoughtMagicShopItem(this UserStatsData data, MagicShopItemTypeId magicShopItemTypeId) => default;
		public static int GetBattlesCount(this UserStatsData statsData, AreaTypeId areaTypeId) => default;
		public static void UpdateArenaStats(this UserStatsData data, BattleResultType resultType) {}
		public static void UpdateArena3X3Stats(this UserStatsData data, bool isWin) {}
		public static void ResetArena3X3Stats(this UserStatsData data) {}
		public static void ResetArenaStats(this UserStatsData data) {}
		public static int GetBoughtShardsCount(this UserStatsData statsData) => default;
		public static int GetBoughtArtifactsCount(this UserStatsData statsData) => default;
	}
}
