
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
using SharedModel.Meta.Alliances.Boss;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	// [RemovedJson]
	public class QuestCompletionByBattle
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
		public int? TargetTypeId;
		[Json]
		// [Key]
		public TargetKindId? TargetKindId;
		[Json]
		// [Key]
		public bool? AutobattleOnly;
		[Json]
		// [Key]
		public int? WinsInStoryBattles;
		[Json]
		// [Key]
		public int? MinHeroLevel;
		[Json]
		// [Key]
		public int? HeroesCount;
		[Json]
		// [Key]
		public bool? GreaterOrEqual;
		[Json]
		// [Key]
		public bool? OnlyVictory;
		[Json]
		// [Key]
		public BattleQuestAction? Action;
		[Json]
		// [Key]
		public bool? OneClanBoss;
		[Json]
		// [Key]
		public bool? AllowDifferentAlliances;
		[Json]
		// [Key]
		public bool? WithNoLosses;
		[Json]
		// [Key]
		public bool? AllHeroesOfTheSameElement;
		[Json]
		// [Key]
		public bool? AllHeroesOfDifferentElement;
		[Json]
		// [Key]
		public bool? AllHeroesOfTheSameFraction;
		[Json]
		// [Key]
		public bool? AllHeroesOfMaxLevelAndGrade;
		[Json]
		// [Key]
		public AreaTypeId[] AreaTypeIds;
		[Json]
		// [Key]
		public AreaTypeId? AreaTypeId;
		[Json]
		// [Key]
		public RegionTypeId? RegionTypeId;
		[Json]
		// [Key]
		public int? StageOrFloorNumber;
		[Json]
		// [Key]
		public int? MinStageOrFloorNumber;
		[Json]
		// [Key]
		public DifficultyId? Difficulty;
		[Json]
		// [Key]
		public bool? AgainstHigherTeamPower;
		[Json]
		// [Key]
		public AllianceBossTypeId? MinAllianceBossTypeId;
		[Json]
		// [Key]
		public bool? CollectStars;
		[Json]
		// [Key]
		public ArtifactStatKey ArtifactStatKey;
		[Json]
		// [Key]
		public ArtifactKindId? ArtifactKindId;
		[Json]
		// [Key]
		public ArtifactRankId? ArtifactRankId;
		[Json]
		// [Key]
		public ArtifactSetKindId? ArtifactSetKindId;
		[Json]
		// [Key]
		public bool? BuffApplied;
		[Json]
		// [Key]
		public bool? DebuffApplied;
		[Json]
		// [Key]
		public List<EffectKindId> UserEffectKindIds;
		[Json]
		// [Key]
		public List<StatusEffectTypeId> UserAppliedStatusEffectTypeIds;
		[Json]
		// [Key]
		public AllianceBossTypeId? AllianceBossId;
		[Json]
		// [Key]
		public long? AllianceBossRevision;
		[Json]
		// [Key]
		public long? AllianceId;
		[Json]
		// [Key]
		public int? NotUsedSkillIdByTarget;
		[Json]
		// [Key]
		public bool? IfKilledEnemy;
		[Json]
		// [Key]
		public bool? IfKilledEnemyInOneTurn;
		[Json]
		// [Key]
		public Element? KilledHeroesElement;
		[Json]
		// [Key]
		public Element? LevelUpHeroesElement;
		[Json]
		// [Key]
		public Element? UserHeroElement;
		[Json]
		// [Key]
		public HeroRarity? UserHeroRarity;
		[Json]
		// [Key]
		public bool? FirstTurnTaken;
		[Json]
		// [Key]
		public int? UncommonHeroesCount;
		[Json]
		// [Key]
		public int? TurnsTaken;
		[IgnoreMember]
		[JsonSkip]
		private int? _stageId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int? StageId { get => default; }
	
		// Constructors
		public QuestCompletionByBattle() {}
	
		// Methods
		public bool IsCompleted(UserStageData readData) => default;
		public QuestCompletionProgress CalcProgress(UserStageData readData) => default;
		public QuestCompletionByBattle Clone() => default;
		private bool CheckStageConditions(Stage stage) => default;
		public void RefreshAllianceRelatedData(long? allianceId, AllianceBossTypeId? allianceBossId, long? allianceBossRevision) {}
	}
}
