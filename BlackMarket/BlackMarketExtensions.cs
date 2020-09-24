
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Effects;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Forge.Static;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.BlackMarket
{
	public static class BlackMarketExtensions
	{
		// Extension methods
		public static BlackMarketItem Type(this BlackMarketItemId itemId) => default;
		public static BlackMarketItem AssertItemExists(this StaticBlackMarketData staticData, BlackMarketItemId itemId) => default;
		public static BmiBox AssertItemExists(this UserBlackMarketData userData, BlackMarketItemId itemId, int count = 1) => default;
		public static List<BmiBox> AssertItemsExist(this UserBlackMarketData userData, Dictionary<BlackMarketItemId, int> bmiCountById) => default;
		public static void AssertItemExist(this UserBlackMarketData userData, BlackMarketItemId itemId) {}
		public static void AssertItemsValidKind(this Dictionary<BlackMarketItemId, int> bmiCountById, BlackMarketItemKindId kindId) {}
		public static IUndoState AddItem(this UserBlackMarketData userData, BlackMarketItemId itemId, int count = 1, DateTime? expiryDate = default) => default;
		public static IUndoState RemoveItem(this UserBlackMarketData userData, BlackMarketItemId itemId, int count = 1) => default;
		public static IUndoState RemoveItems(this UserBlackMarketData userData, Dictionary<BlackMarketItemId, int> bmiCountById) => default;
		public static IUndoState<BmiBox> GetOrAddDefault(this Dictionary<BlackMarketItemId, BmiBox> boxesItems, BlackMarketItemId typeId) => default;
		public static bool IsEnable(this StaticBlackMarketData sd, BlackMarketItemId itemId) => default;
		public static bool IsResource(this BlackMarketItemId itemId) => default;
		public static bool IsShard(this BlackMarketItemId itemId) => default;
		public static bool IsShardOfType(this BlackMarketItemId itemId, ShardTypeId shardTypeId) => default;
		public static bool IsEffect(this BlackMarketItemId itemId) => default;
		public static bool IsSkillUpgradeItem(this BlackMarketItemId itemId) => default;
		public static bool IsHeroLevelUpgradeItem(this BlackMarketItemId itemId) => default;
		public static bool IsHeroRankUpgradeItem(this BlackMarketItemId itemId) => default;
		public static bool IsRandomItem(this BlackMarketItemId itemId) => default;
		public static bool IsForgeBooster(this BlackMarketItemId itemId) => default;
		public static BlackMarketItemId ToCharmCategory(this BlackMarketItemId itemId) => default;
		public static bool IsPowerUpItem(this BlackMarketItemId itemId) => default;
		public static BlackMarketItem AddPrice(this BlackMarketItem item, Account.Resources price) => default;
		public static BlackMarketItem AddResourcesData(this BlackMarketItem item, bool maxEnergy = false, bool maxTokens = false, bool maxArena3X3Tokens = false) => default;
		public static BlackMarketItem AddShardData(this BlackMarketItem item, ShardTypeId typeId) => default;
		public static BlackMarketItem AddUpdateUserData(this BlackMarketItem item, UpdateUserType type) => default;
		public static BlackMarketItem AddSkillUpgradeData(this BlackMarketItem item, params HeroRarity[] rarities) => default;
		public static BlackMarketItem AddHeroLevelUpItemData(this BlackMarketItem item, Element element, int xp, int correctElementXp, Account.Resources price) => default;
		public static BlackMarketItem AddHeroRankUpItemData(this BlackMarketItem item, HeroGrade grade) => default;
		public static BlackMarketItem AddPowerUpItemData(this BlackMarketItem item, ArtifactRankId rankId, StatKindId statId, bool isAbsolute, double minValue, double maxValue, double step, Account.Resources usePrice, Account.Resources sellPrice) => default;
		public static BlackMarketItem AddRandomPowerUpItemData(this BlackMarketItem item, ArtifactRankId rankId) => default;
		public static BlackMarketItem AddEffectData(this BlackMarketItem item, UserEffectTypeId typeId, double power, TimeSpan duration) => default;
		public static BlackMarketItem AddMasteryPointsData(this BlackMarketItem item, MasteryPointType type) => default;
		public static BlackMarketItem AddCharmData(this BlackMarketItem item, ForgeCharmProbabilities probabilities) => default;
		public static BlackMarketItem GetForgeCharm(this StaticBlackMarketData data, BlackMarketItemId blackMarketItemId) => default;
		// [IteratorStateMachine]
		public static IEnumerable<IGrouping<ForgeCharmTypeId, BlackMarketItem>> AssertHasMultipleCharmOfSameType(this IEnumerable<IGrouping<ForgeCharmTypeId, BlackMarketItem>> groupedCharms) => default;
		public static ForgeCharmTypeId ToForgeCharmTypeId(this BlackMarketItemId itemId) => default;
		public static BlackMarketItemKindId ToKindId(this BlackMarketItemId itemId) => default;
		public static bool IsPowerUpStone(this BlackMarketItem item) => default;
	}
}
