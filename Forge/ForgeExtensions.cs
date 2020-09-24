
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Forge.Static;



namespace SharedModel.Meta.Forge
{
	public static class ForgeExtensions
	{
		// Extension methods
		public static ForgeArtifactRecipe RecipeOrThrow(this StaticForgeData data, int id) => default;
		public static Dictionary<ForgeCharmTypeId, BlackMarketItem> ValidCharmsOrThrow(this StaticBlackMarketData data, UserBlackMarketData readUserData, BlackMarketItemId[] charmIds) => default;
		public static ForgeCharmProbabilitiesTypeId ToProbabilitiesType(this OutputRankVariationId id) => default;
		public static ForgeCharmTypeId ToCharmType(this ForgeCharmProbabilitiesTypeId id) => default;
		public static void AssertFirstTimeRewardNotTaken(this UserForgeData data) {}
		public static void AssertLevelIsEnough(this UserAccount account, int requiredLevel) {}
	}
}
