
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Stages;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByLoot
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
		public AreaTypeId? AreaTypeId;
		[Json]
		// [Key]
		public RegionTypeId? RegionTypeId;
		[Json]
		// [Key]
		public int? StageOrFloorNumber;
		[Json]
		// [Key]
		public DifficultyId? Difficulty;
		[Json]
		// [Key]
		public bool? StageEqualsOrHigher;
		[Json]
		// [Key]
		public bool? AnyHero;
		[Json]
		// [Key]
		public List<ResourceTypeId> ResourcesTypeIds;
		[Json]
		// [Key]
		public ArtifactLootInfo ArtifactInfo;
		[Json]
		// [Key]
		public List<ArtifactLootInfo> ArtifactInfos;
		[Json]
		// [Key]
		public List<Artifact> GainedArtifacts;
	
		// Constructors
		public QuestCompletionByLoot() {}
	
		// Methods
		public bool IsCompleted(UserStageData readData) => default;
		public QuestCompletionProgress CalcProgress(UserStageData readData) => default;
		public bool CheckStageProperties(Stage stage) => default;
		private bool CheckAreaTypeId(AreaTypeId areaTypeId) => default;
		public bool CheckRegionTypeId(RegionTypeId regionTypeId) => default;
		public bool CheckDifficultyId(DifficultyId difficultyId) => default;
		public bool CheckStageOrFloorNumber(Stage stage) => default;
		public QuestCompletionByLoot Clone() => default;
		public void TryIncrementCountCollected(UserPrize reward) {}
		private static bool TryIncrementArtifactsCountCollected(Artifact artifact, ArtifactLootInfo info, List<Artifact> gainedArtifacts) => default;
	}
}
