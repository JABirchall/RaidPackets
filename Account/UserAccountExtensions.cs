
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Subscriptions.Data;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Account
{
	public static class UserAccountExtensions
	{
		// Methods
		private static bool SkipRefreshDailyTickets(UserAccount account, DateTime now) => default;
	
		// Extension methods
		public static void AddExperience(this UserAccount account, long amount) {}
		public static IUndoState AddExperience(this UserAccount account, long amount, out int addedLevels) {
			addedLevels = default;
			return default;
		}
		public static double GetExperienceNormalized(this UserAccount account) => default;
		public static Resources ProcessLimitedTypes(this Resources resources, UserAccount account) => default;
		public static IUndoState<Resources> AddResources(this UserAccount account, Resources resources) => default;
		private static IUndoState AddResourcesStats(this UserAccount account, Resources resources) => default;
		public static IUndoState SubtractResources(this UserAccount account, Resources resources) => default;
		private static IUndoState SpendResourcesStats(this UserAccount account, Resources resources) => default;
		public static bool IsEnough(this UserAccount account, Resources res) => default;
		public static UserAccount AssertIsEnough(this UserAccount account, Resources res) => default;
		public static bool EnergyLimitReached(this UserAccount account) => default;
		public static bool TokensLimitReached(this UserAccount account) => default;
		public static bool Arena3X3TokensLimitReached(this UserAccount account) => default;
		public static bool SkipRefreshArena3X3Tokens(this UserAccount account, DateTime now) => default;
		public static void ProcessBuySubscription(this UserAccount account, UserEffectData effectData, DateTime now, Subscription userSubscription) {}
		public static bool RefreshDailyTickets(this UserAccount account, UserEffectData effectData, DateTime now) => default;
		public static double GetAutoBattleTicketsLimit(this UserAccount account, UserEffectData effectData, DateTime now) => default;
		public static UserPrize AssertMilestonePrizeExists(this UserAccount account, int level) => default;
		public static int GetNextLevelExp(this StaticUserLevelData staticData, int level) => default;
		public static void AssertIdfaAgreement(this UserAccount account) {}
	}
}
