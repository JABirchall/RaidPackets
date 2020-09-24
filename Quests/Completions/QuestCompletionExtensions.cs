
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Hero;
using SharedModel.Battle.Core.Hero.Statistics;
using SharedModel.Battle.Core.Result;
using SharedModel.Battle.Core.Setup;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Account;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.Alliances.Boss;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Heroes.Entities;
using SharedModel.Meta.PeriodicQuests.Data;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Quests.Data;
using SharedModel.Meta.Shards;
using SharedModel.Meta.Skills;
using SharedModel.Meta.Stages;
using SharedModel.Meta.Stats;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Quests.Completions
{
	public static class QuestCompletionExtensions
	{
		// Methods
		private static bool SkipCompletion(BattleResult battleResult, QuestCompletionByBattle byBattle) => default;
		public static bool TryCompleteByDamageToAllianceBoss(BattleResult battleResult, QuestCompletionByBattle byBattle, UserAllianceData allianceData) => default;
		public static bool TryCompleteByBattleSideArguments(UserStatsData statsData, UserHeroData heroData, BattleResult battleResult, UserPrize reward, QuestCompletionByBattle completion, out int countCollected) {
			countCollected = default;
			return default;
		}
		private static int GetBattleHeroIdByHeroTypeId(BattleResult battleResult, int heroTypeId, long teamOwnerId) => default;
		// [IteratorStateMachine]
		private static IEnumerable<TurnStatistics> GetAllTurnsStatistics(BattleResult battleResult, long teamOwnerId) => default;
		private static bool ArtifactsFound(UserPrize reward, Predicate<Artifact> condition) => default;
		private static void CalcSatisfyingTurnsCount(QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected, Func<TurnStatistics, bool> satisfyCondition) {}
		private static bool CheckEffectKindId(TurnStatistics turn, bool buff) => default;
		private static bool CheckLevelUpAllSkills(QuestCompletionByHero completion, Hero hero, HeroQuestAction action) => default;
		private static bool CheckMaterialIsSameHero(QuestCompletionByHero completion, Hero hero, int[] materialHeroIds, BlackMarketItemId[] materialBmiIds) => default;
		private static bool CheckMaterialIsBlackMarketItem(QuestCompletionByHero completion, int[] materialHeroIds, BlackMarketItemId[] materialBmiIds) => default;
		private static bool CheckCountLevelRaised(QuestCompletionByHero completion, int? levelsUpped, ref int countCollected) => default;
		private static bool CheckShardTypeId(ShardTypeId? shardTypeId, QuestCompletionByHero byHero) => default;
		private static bool CheckSkillLevel(Hero hero, QuestCompletionByHero byHero, bool greaterOrEqual) => default;
		private static bool CheckAwakeLevel(Hero hero, QuestCompletionByHero byHero) => default;
		private static bool CheckLevelUpSource(HeroLevelUpSource? levelUpSource, QuestCompletionByHero byHero) => default;
		private static bool CheckLevel(Hero hero, QuestCompletionByHero byHero) => default;
		private static bool CheckElement(Hero hero, QuestCompletionByHero byHero) => default;
		private static bool CheckGrade(Hero hero, QuestCompletionByHero byHero, bool greaterOrEqual) => default;
		private static bool CheckRole(Hero hero, QuestCompletionByHero byHero, bool greaterOrEqual) => default;
		private static bool CheckRarity(Hero hero, QuestCompletionByHero byHero, bool greaterOrEqual) => default;
		private static bool CheckHeroTypeId(Hero hero, QuestCompletionByHero byHero) => default;
		private static bool CheckAction(HeroQuestAction action, QuestCompletionByHero byHero) => default;
		private static bool CheckAscendAllFractionHeroes(Hero hero, QuestCompletionByHero byHero) => default;
		private static bool CheckAscendAllElementHeroes(Hero hero, QuestCompletionByHero byHero) => default;
		private static bool CheckArtifactCondition(QuestCompletionByArtifact comp, Artifact artifact, Hero hero) => default;
		public static bool CompareArtifacts(Artifact artifact, ArtifactKindId? kind, ArtifactRankId? rank, ArtifactSetKindId? setKind, StatKindId? statKind, ArtifactStatKey statKey, int? level) => default;
		public static bool CompareArtifactsWithSoftRankCondition(Artifact artifact, ArtifactKindId? kind, ArtifactRankId? rank, ArtifactRarityId? rarityId, ArtifactSetKindId? setKind, StatKindId? statKind, ArtifactLootTypeId? lootTypeId, ArtifactStatKey statKey, int? level) => default;
	
		// Extension methods
		public static bool TryCompleteByBattle(this QuestCompletion completion, UserStatsData statsData, UserAllianceData allianceData, UserHeroData heroData, BattleResult battleResult, UserPrize reward) => default;
		private static bool CheckAllianceBossRevision(this QuestCompletionByBattle byBattle, long revision) => default;
		private static bool CheckIfToRefreshProgress(this QuestCompletionByBattle byBattle, AllianceBossTypeId bossId, long revision) => default;
		private static bool TheSameBossAs(this QuestCompletionByBattle byBattle, AllianceBossTypeId bossId) => default;
		private static bool CheckAllianceId(this QuestCompletionByBattle byBattle, long? allianceId) => default;
		public static bool TryCompleteByArena(this QuestCompletion completion, UserArenaData arenaData, BattleResult battleResult, UserPrize reward, long userId, int earnedPoint, bool userIsDefender, int userLevel) => default;
		public static void TryProcessEarnedMedals(this QuestCompletionByArena byArena, Account.Resources resources) {}
		public static bool TryCompleteByLoot(this QuestCompletion completion, BattleResult battleResult, UserPrize reward) => default;
		public static bool CheckArtifactRankId(this QuestCompletionByBattle byBattle, UserPrize prize) => default;
		public static bool CheckArtifactKindId(this QuestCompletionByBattle byBattle, UserPrize prize) => default;
		public static bool CheckArtifactStatKey(this QuestCompletionByBattle byBattle, UserPrize prize) => default;
		public static bool CheckArtifactSetKindId(this QuestCompletionByBattle byBattle, UserPrize prize) => default;
		public static bool CheckAreaTypeId(this QuestCompletionByBattle byBattle, AreaTypeId areaTypeId) => default;
		public static bool CheckAreaTypeIds(this QuestCompletionByBattle byBattle, AreaTypeId areaTypeId) => default;
		public static bool CheckRegionTypeId(this QuestCompletionByBattle byBattle, RegionTypeId regionTypeId) => default;
		public static bool CheckDifficultyId(this QuestCompletionByBattle byBattle, DifficultyId difficultyId) => default;
		public static bool CheckStageOrFloorNumber(this QuestCompletionByBattle byBattle, int stageOrFloorNumber) => default;
		public static int? GetStageOrFloorNumber(this QuestCompletionByBattle completion) => default;
		public static bool CheckWinsInStoryBattles(this QuestCompletionByBattle byBattle, int storyWinsCount) => default;
		public static bool CheckIfAutobattle(this QuestCompletionByBattle byBattle, bool isAutoBattle) => default;
		public static bool CheckHeroesCount(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		public static bool CheckMinHeroLevel(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		public static bool CheckIfWithNoLosses(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckAllHeroesOfTheSameElement(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckAllHeroesOfDifferentElement(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckAllHeroesOfTheSameFraction(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckNotUsedSkillIdByTarget(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckAllHeroesOfMaxLevelAndGrade(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckUserAppliedStatusEffectTypeIds(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckIfKilledEnemyInOneTurn(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckIfKilledEnemy(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckUserBuffApplied(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckUserDeBuffApplied(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckUserEffectKindIds(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckKilledEnemyAndHasUncommonHeroes(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckKilledHeroesElement(this QuestCompletionByBattle byBattle, BattleResult battleResult, ref int countCollected) => default;
		private static bool CheckLevelUpHeroesElement(this QuestCompletionByBattle byBattle, BattleResult battleResult, UserHeroData heroData, ref int countCollected) => default;
		private static bool CheckIfHigherTeamPower(this QuestCompletionByBattle byBattle, BattleResult battleResult) => default;
		private static bool CheckFirstTurnTaken(this QuestCompletionByBattle completion, BattleResult battleResult) => default;
		private static bool CheckTurnsTaken(this QuestCompletionByBattle completion, BattleResult battleResult) => default;
		private static bool CheckUserHeroElement(this QuestCompletionByBattle completion, BattleResult battleResult) => default;
		private static bool CheckUserHeroRarity(this QuestCompletionByBattle completion, BattleResult battleResult) => default;
		public static bool TryCompleteByClientCode(this QuestCompletion completion, QuestCompletionByClientCode code, long param) => default;
		public static bool TryCompletePeriodic(this QuestCompletion completion, ComplexSource source, params PeriodicQuestPrototypeId[] prototypeIds) => default;
		public static bool TryCompleteByQuest(this QuestCompletion completion, Quest quest) => default;
		public static bool IsBattleAllianceRelated(this QuestCompletion completion) => default;
		public static bool IsOneClanBossBattleQuest(this QuestCompletion completion) => default;
		public static void RefreshBattleAllianceRelatedData(this QuestCompletion completion, long? allianceId, AllianceBossTypeId? allianceBossId, long? allianceBossRevision) {}
		public static bool TryCompleteByHero(this QuestCompletion completion, Hero hero, HeroQuestAction action, int? levelsUpped = default, ShardTypeId? shardTypeId = default, HeroLevelUpSource? levelUpSource = default, int[] materialHeroIds = null, BlackMarketItemId[] materialBmiIds = null) => default;
		public static bool TryCompleteByArtifact(this QuestCompletion completion, Artifact artifact, ArtifactQuestAction? action = default, Hero hero = null, bool? successful = default) => default;
		public static bool TryCompleteByAction(this QuestCompletion completion, QuestCompletionByActionCode code, ComplexSource source, int actionsCount = 1) => default;
		public static bool TryCompleteByMastery(this QuestCompletion completion, Hero hero, int masteryId) => default;
		public static bool TryCompleteByMasteryPoints(this QuestCompletion completion, int addedPoints) => default;
		public static bool TryCompleteByResourceSpent(this QuestCompletion completion, Account.Resources resources) => default;
		public static bool TryCompleteByFuse(this QuestCompletion completion, int? heroTypeId = default, ResourceTypeId? resourceTypeId = default, int count = 1) => default;
		public static bool TryCompleteByForge(this QuestCompletion completion, Artifact artifact) => default;
	}
}
