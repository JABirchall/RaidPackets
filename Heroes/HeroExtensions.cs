
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core;
using SharedModel.Battle.Core.Setup;
using SharedModel.Battle.Effects;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes.Dtos;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.Skills;
using SharedModel.Meta.Stages;
using SharedModel.Meta.TrainingCamp;
using SharedModel.Meta.Village;



namespace SharedModel.Meta.Heroes
{
	public static class HeroExtensions
	{
		// Fields
		private static readonly Dictionary<int, double> TotalPowerBonusBySetKindId;
		private static readonly Dictionary<int, double> MasteryBonusByRow;
		private static HeroGrade[] _heroGrades;
	
		// Constructors
		static HeroExtensions() {}
	
		// Methods
		public static HeroGrade MinHeroGrade() => default;
		public static HeroGrade MaxHeroGrade() => default;
		private static BattleStats GetMasteryBonusValue(ArtifactSetStatBonus masteryBonus, BattleStats baseStats, List<ArtifactSetSetup> artifactSetSetups) => default;
		private static void ChangeStatsWithArtifactSetMasteryBonus(ArtifactSetStatBonus masteryBonus, List<ArtifactSetSetup> artifactSetSetups, BattleStats stats) {}
		private static bool IsFlatBonusForArtifactSet(StatKindId statKindId) => default;
		private static int GetBattlePresetKey(AreaTypeId area, int slotsCount) => default;
		public static int GetBattlePresetKey(RegionTypeId region, int slotsCount) => default;
		private static int CalcTotalPowerDiff(double basePower, double bonusPower) => default;
	
		// Extension methods
		public static Hero GetHero(this UserHeroData heroData, int id) => default;
		public static IEnumerable<Hero> GetHeroes(this UserHeroData heroData, IEnumerable<int> heroIds) => default;
		public static IEnumerable<Hero> GetHeroesWhoExist(this UserHeroData heroData, IEnumerable<int> heroIds) => default;
		public static IUndoState RemoveHero(this UserHeroData heroData, int id, UserArtifactData artifactData = null) => default;
		public static UserHeroData RemoveHeroes(this UserHeroData heroData, List<Hero> heroes, UserArtifactData artifactData) => default;
		public static Hero AddHero(this UserHeroData heroData, int typeId, HeroGrade? grade = default, int level = 1, bool? locked = default) => default;
		public static IUndoState<Hero> AddHeroImpl(this UserHeroData heroData, int typeId, HeroGrade? grade = default, int level = 1, bool? locked = default) => default;
		public static IUndoState AddHero(this UserHeroData heroData, Hero hero) => default;
		public static Hero FindHero(this UserHeroData heroData, int typeId, bool withMaxLevel = false) => default;
		public static Hero AssertHeroExists(this UserHeroData heroData, int id) => default;
		public static StaticHeroData AssertHeroExists(this StaticHeroData staticHeroData, int typeId) => default;
		public static bool IsValid(this HeroType type, HeroGrade grade, int level) => default;
		public static IUndoState<Dictionary<int, int>> AddHeroParts(this UserHeroData heroData, Dictionary<int, int> heroParts) => default;
		public static IUndoState<Dictionary<int, int>> SubtractHeroParts(this UserHeroData heroData, int heroTypeId, int count) => default;
		public static UserHeroData AssertHeroPartsEnough(this UserHeroData data, int heroTypeId, int requiredAmount) => default;
		public static bool AssertValidHeroParts(this Dictionary<int, int> heroParts, bool throwException = true, bool checkHeroStatus = true) => default;
		public static int AssertHeroPartsExists(this StaticHeroData data, int heroTypeId) => default;
		public static Hero AssertIsValidMaterialCount(this Hero hero, int materialCount) => default;
		public static Hero AssertIsValidRankUpMaterial(this Hero hero, BlackMarketItemId[] bmiIds) => default;
		public static Hero AssertAwakenIs(this Hero hero, bool isTrue) => default;
		public static Hero AssertAwakeableIs(this Hero hero, bool isTrue) => default;
		public static Hero AscendHero(this UserHeroData heroData, int heroId, UserArtifactData artifactData) => default;
		public static IUndoState<Hero> AscendHeroImpl(this UserHeroData heroData, int heroId, UserArtifactData artifactData) => default;
		public static Hero DescendHero(this UserHeroData heroData, int ascendedHeroId, Hero hero, UserArtifactData artifactData) => default;
		public static IUndoState RankUpHero(this Hero hero) => default;
		public static int AddExperience(this UserHeroData heroData, IEnumerable<int> heroIds, int amount) => default;
		public static int AddExperience(this Hero hero, int amount) => default;
		public static IUndoState<int> AddExperienceImpl(this Hero hero, int amount) => default;
		public static int CalcSacrificeXp(this Hero hero) => default;
		public static HeroRace GetRace(this Hero hero) => default;
		public static HeroRace GetRace(this HeroType heroType) => default;
		public static Hero AssertMaxGradeIs(this Hero hero, bool isTrue) => default;
		public static Hero AssertSameGradeWith(this Hero hero, Hero heroToCompare, bool isTrue) => default;
		public static Hero AssertHasGradeOf(this Hero hero, HeroGrade grade) => default;
		public static HeroGrade GetInitialGrade(this HeroRarity rarity) => default;
		public static bool IsCommon(this HeroRarity rarity) => default;
		public static bool IsUncommon(this HeroRarity rarity) => default;
		public static bool IsRare(this HeroRarity rarity) => default;
		public static bool IsEpic(this HeroRarity rarity) => default;
		public static bool IsLegendary(this HeroRarity rarity) => default;
		public static float GetNormalizedLevel(this Hero hero, int additionalExp = 0) => default;
		public static bool IsMaxExperience(this Hero hero) => default;
		public static bool IsMaxLevel(this Hero hero) => default;
		public static int GetMaxLevel(this HeroGrade grade) => default;
		public static int CreateGradeLevelKey(this HeroGrade grade, int level) => default;
		public static Account.Resources GetLevelUpPrice(this Hero hero) => default;
		public static Hero AssertMaxLevelIs(this Hero hero, bool isTrue) => default;
		public static Hero AssertMaxExperienceForLevelIs(this Hero hero, bool isTrue, int addedXp) => default;
		public static Account.Resources GetSkillLevelUpPrice(this Hero hero) => default;
		public static int GetPossibleSkillLevelUps(this Hero hero) => default;
		public static Hero AssertAwakeLevelIsEqualOrGreaterThan(this Hero hero, int awakeLevel) => default;
		public static Hero AssertHeroInSameFamilyWith(this Hero hero, HeroType compareType) => default;
		public static int[] GetBattlePreset(this UserHeroData heroData, AreaTypeId area, RegionTypeId region, int slotsCount) => default;
		public static IUndoState UpdateBattlePresets(this UserHeroData heroData, Stage stage, int[] heroes) => default;
		public static int AssertIsValidDto(this LevelUpSkillRequestDto dto, int maxCount) => default;
		public static List<Hero> AssertHeroesExist(this UserHeroData data, IEnumerable<int> materialHeroIds) => default;
		public static int CalcXpToAdd(this Hero hero, TrainingCampSlotInfo slot) => default;
		public static int CalcHeroPower(this Hero hero, long userId, UserAccount account, UserArtifactData artifactData, UserVillageData villageData, UserArenaData arenaData) => default;
		public static BattleStats CalcHeroStatBonuses(this Hero hero, ArenaLeagueId leagueId, BuildingSetup buildingSetup, IEnumerable<Artifact> artifacts) => default;
		public static BattleStats CalcArtifactsBonus(this Hero hero, List<ArtifactSetup> artifactSetups) => default;
		public static BattleStats CalcBuildingsBonus(this Hero hero, BuildingSetup buildingSetup) => default;
		public static BattleStats CalcArenaBonus(this Hero hero, ArenaLeagueId leagueId) => default;
		public static BattleStats CalcMasteriesBonus(this Hero hero, List<ArtifactSetup> artifactSetups) => default;
		public static int CalcBuildingsPower(this Hero hero, BuildingSetup buildingSetup) => default;
		public static int CalcArenaPower(this Hero hero, ArenaLeagueId leagueId) => default;
		public static int CalcMasteriesPower(this Hero hero, List<ArtifactSetup> artifactSetups) => default;
		public static int MasteryBonusPower(this Hero hero) => default;
		public static int CalcArtifactsPower(this Hero hero, List<ArtifactSetup> artifactSetups, List<ArtifactSetInfo> activeSets) => default;
		public static int ArtifactSetBonus(this Hero hero, IEnumerable<ArtifactSetInfo> activeSets) => default;
		public static UserHeroData UpdateRecentBattleTime(this UserHeroData heroData, IEnumerable<int> heroIds, DateTime time) => default;
		public static UserHeroData UpdateHeroesStatistics(this UserHeroData heroData, IEnumerable<int> heroIds, BattleStatistics statistics) => default;
		public static IUndoState ReplaceHeroIdInBattlePresets(this UserHeroData heroData, int oldHeroId, int newHeroId) => default;
		public static bool IsMaxRank(this Hero hero) => default;
		public static List<Skills.Skill> GetUpgradableSkills(this Hero hero) => default;
		public static int GetAvailableSkillsLevelUpgradeCount(this Hero hero) => default;
		public static Hero AssertIsValidSkillUpMaterials(this Hero hero, List<Hero> heroMaterials, Dictionary<BlackMarketItemId, int> bmiCountById) => default;
		public static bool IsValidSkillUpMaterials(this Hero hero, IEnumerable<Hero> heroMaterials) => default;
		public static bool IsValidSkillUpMaterials(this Hero hero, IEnumerable<BlackMarketItemId> bmiMaterials) => default;
		public static bool IsValidRankUpMaterials(this Hero hero, IEnumerable<BlackMarketItemId> bmiMaterials) => default;
		public static bool IsValidLevelUpMaterials(this Hero hero, IEnumerable<BlackMarketItemId> bmiMaterials) => default;
		public static bool CanBeAwakened(this Hero hero) => default;
		public static Skills.Skill LevelUp(this Skills.Skill skill) => default;
		public static BattleStats GetBaseStats(this Hero hero) => default;
		public static bool IsEnoughInventorySlots(this UserHeroData data, int count) => default;
		public static void AssertHeroNotLocked(this UserHeroData data, int heroId) {}
		public static Hero AssertApplicableGradeAndLevel(this Hero hero, HeroGrade grade, int level) => default;
		public static UserHeroData AssertIsEnoughInventorySlots(this UserHeroData data, int count = 1) => default;
		public static void AssertHeroReadyStatus(this List<HeroSlotSetup> heroSlotSetups) {}
		public static Account.Resources GetNextInventorySlotsPrice(this UserHeroData data, ResourceTypeId buyResourceType) => default;
		public static InventorySlotsPrice GetNextInventorySlotsPrice(this UserHeroData data) => default;
		public static IUndoState UpdateInventorySlotsCount(this UserHeroData data) => default;
		public static int NextInventorySlotsCount(this UserHeroData data) => default;
		public static UserHeroData AssertNotMaxInventorySlots(this UserHeroData data) => default;
		public static void AssertHeroesNotInStorage(this UserHeroData data, IEnumerable<int> heroIds) {}
		public static void AssertHeroNotInStorage(this UserHeroData data, int heroId) {}
		public static Hero AssertHeroNotInStorage(this Hero hero) => default;
		public static Account.Resources GetNextStorageHeroSlotsPrice(this UserHeroData data, ResourceTypeId buyResourceType) => default;
		public static InventorySlotsPrice GetNextStorageHeroSlotsPrice(this UserHeroData data) => default;
		public static IUndoState UpdateStorageSlotsCount(this UserHeroData data) => default;
		public static int NextStorageSlotsCount(this UserHeroData data) => default;
		public static UserHeroData AssertNotMaxStorageSlots(this UserHeroData data) => default;
	}
}
