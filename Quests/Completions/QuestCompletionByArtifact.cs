
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Village;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	// [RemovedJson]
	public class QuestCompletionByArtifact
	{
		// Fields
		[Json]
		// [Key]
		public int CountRequired;
		[Json]
		// [Key]
		public int CountCollected;
		[Json]
		// [Key]
		public int[] UpgradeToLevels;
		[Json]
		// [Key]
		public int? UpgradeToLevel;
		[Json]
		// [Key]
		public int? IsOfLevel;
		[Json]
		// [Key]
		public bool? EveryUpgrade;
		[Json]
		// [Key]
		public int? MinLevel;
		[Json]
		// [Key]
		public ArtifactKindId? KindId;
		[Json]
		// [Key]
		public ArtifactRankId? RankId;
		[Json]
		// [Key]
		public ArtifactRarityId? RarityId;
		[Json]
		// [Key]
		public ArtifactStatKey StatKey;
		[Json]
		// [Key]
		public StatKindId? StatKind;
		[Json]
		// [Key]
		public List<ArtifactKindId> KindIdsOnOneHero;
		[Json]
		// [Key]
		public HeroRole? HeroRole;
		[Json]
		// [Key]
		public HeroRarity? HeroRarity;
		[Json]
		// [Key]
		public int? ArtifactSetsCount;
		[Json]
		// [Key]
		public int? HeroesCountWithSets;
		[Json]
		// [Key]
		public BattleStats StatsRequired;
		[Json]
		// [Key]
		public ArtifactSetKindId? RequiredSetKind;
		[Json]
		// [Key]
		public int? ArtifactsCount;
		[Json]
		// [Key]
		public int? HeroesCount;
		[Json]
		// [Key]
		public AccessoryQuestAction? AccessoryAction;
		[Json]
		// [Key]
		public ArtifactQuestAction? ArtifactAction;
		[Json]
		// [Key]
		public bool? OnlySuccessfulAction;
		[Json]
		// [Key]
		public bool? AccessoryOnly;
		[Json]
		// [Key]
		public bool? ArtifactOnly;
		[Json]
		// [Key]
		public int? ArtifactsCountInSet;
		[Json]
		// [Key]
		public ArtifactRankId? ArtifactSetRank;
		[Json]
		// [Key]
		public ArtifactRarityId? ArtifactSetRarity;
		[Json]
		// [Key]
		public ArtifactSetKindId? SetKindId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool HasHeroCondition { get => default; }
	
		// Constructors
		public QuestCompletionByArtifact() {}
	
		// Methods
		public bool IsDone(long userId, int userLevel, UserArtifactData artifactData, UserHeroData heroData, UserVillageData villageData, UserArenaData arenaData) => default;
		public bool IsCompleted(long userId, int userLevel, UserArtifactData artifactData, UserHeroData heroData, UserVillageData villageData, UserArenaData arenaData) => default;
		public QuestCompletionProgress CalcProgress(long userId, int userLevel, UserArtifactData artifactData, UserHeroData heroData, UserVillageData villageData, UserArenaData arenaData) => default;
		private bool TryGetProgressForKindsOnOneHero(List<int> filteredHeroIds, UserArtifactData artifactData, out QuestCompletionProgress progress) {
			progress = default;
			return default;
		}
		private bool TryGetProgressForManyHeroesHaveManyArtifacts(List<int> filteredHeroIds, UserArtifactData artifactData, out QuestCompletionProgress progress) {
			progress = default;
			return default;
		}
		private bool TryGetProgressForArtifactsOfKindOrRankOrStatKey(List<int> filteredHeroIds, UserArtifactData artifactData, out QuestCompletionProgress progress) {
			progress = default;
			return default;
		}
		private ArtifactLootTypeId? TryGetLootTypeId() => default;
		public QuestCompletionByArtifact Clone() => default;
	}
}
