
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Result;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Battle.Arena.Dtos;



namespace SharedModel.Meta.Battle.Arena3x3
{
	public static class Arena3X3Extensions
	{
		// Methods
		public static long CalcWinPoints(long ownPoints, long opponentPoints) => default;
		public static long CalcLoosePoints(long ownPoints, long opponentPoints) => default;
		private static double CalcKFactor(double points, double opponentPoints) => default;
		private static bool AllYearOrCurrentMonthItem(StaticArena3x3ShopItemData shopItem) => default;
	
		// Extension methods
		public static ArenaOpponent FindOpponent(this UserArena3X3Data data, long userId, bool rated) => default;
		public static bool IsEnabled(this StaticArena3X3Data staticData, DateTime now) => default;
		public static bool IsLastBattleInARow(this ArenaOpponent currentOpponent) => default;
		public static bool IsFirstBattleInARow(this ArenaOpponent currentOpponent) => default;
		public static BattleResultType ToBattleResultType(this ArenaOpponentStatus status) => default;
		public static bool IsArena3X3Win(this ArenaOpponent opponent) => default;
		public static List<ArenaOpponentStatus> InverseStatuses(this List<ArenaOpponentStatus> statuses) => default;
		public static ArenaOpponent AssertNotDefeated3X3(this ArenaOpponent opponent) => default;
		public static UserArena3X3Data AssertValidNewArena3X3Battle(this UserArena3X3Data data, long opponentId) => default;
		public static IUndoState AddOrReplaceBoughtItem(this UserArena3X3Data arena3X3Data, UserArena3x3ShopItemData item) => default;
		public static UserArena3x3ShopItemData SelectBoughtItem(this UserArena3X3Data arena3X3Data, int id) => default;
		public static List<StaticArena3x3ShopItemData> ShopItems(this StaticArena3X3Data staticData) => default;
		public static StaticArena3x3ShopItemData ShopItemBy(this StaticArena3X3Data staticData, int slotId) => default;
		public static StaticArena3x3ShopItemData AssertShopItemExist(this StaticArena3X3Data staticData, int id) => default;
		public static StaticArena3x3ShopItemData AssertIsAvailable(this StaticArena3x3ShopItemData item, ArenaLeagueId leagueId) => default;
		public static StaticArena3x3ShopItemData AssertCooldownPassed(this StaticArena3x3ShopItemData item, UserArena3x3ShopItemData boughtItem) => default;
		public static StaticArena3x3ShopItemData AssertItemIsNotPurchased(this StaticArena3x3ShopItemData item, UserArena3x3ShopItemData boughtItem) => default;
	}
}
