
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.AbTests;
using SharedModel.Meta.Account;
using SharedModel.Meta.BattlePasses.Quest;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.BattlePasses
{
	public static class BattlePassExtensions
	{
		// Extension methods
		public static BattlePassLevel LevelOrThrow(this BattlePass data, int levelId) => default;
		public static void SetCurrentBattlePass(this UserBattlePassData data, BattlePass current) {}
		public static bool HasBattlePass(this UserBattlePassData data, int battlePassId) => default;
		public static UserPrize AddBattlePassBonus(this UserPrize prize, DateTime expiration, double power) => default;
		public static UserBattlePass ToUserBattlePass(this BattlePass battlePass) => default;
		public static bool CheckUserCanHaveIt(this BattlePass battlePass, UserAccount account, UserAbTestData abTestData) => default;
		public static int? GetMinUserLevel(this BattlePass battlePass, UserAbTestData abTestData) => default;
		public static void AssertUserHasCurrentBattlePass(this UserBattlePassData data, int currentBattlePassId) {}
		public static BattlePassLevel AssertUserCanCollectLevel(this BattlePassLevel level, UserBattlePass battlePass, BattlePassTypeId battlePassType) => default;
		public static UserPrize RewardOrThrow(this BattlePassLevel level, BattlePassTypeId battlePassType) => default;
		public static bool IsDailyQuest(this BattlePassQuestTypeId? typeId) => default;
		public static bool IsDailyQuest(this BattlePassQuestTypeId typeId) => default;
		public static bool IsWeeklyQuest(this BattlePassQuestTypeId? typeId) => default;
		public static bool IsWeeklyQuest(this BattlePassQuestTypeId typeId) => default;
		public static int? BattlePassWeek(this BattlePassQuestTypeId? self) => default;
		public static bool IsLevelPaymentTypeId(this BattlePassPaymentTypeId typeId) => default;
		public static int ToLevelCount(this BattlePassPaymentTypeId self) => default;
		public static UserPrize ToUserPrize(this BattlePassPaymentTypeId typeId, UserBattlePass battlePass) => default;
		public static bool IsFuture(this BattlePass battlePass) => default;
	}
}
