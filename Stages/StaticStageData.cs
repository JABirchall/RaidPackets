
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.AbTests;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	// [RemovedJson]
	public class StaticStageData
	{
		// Fields
		[Json]
		// [Key]
		public List<Area> Areas;
		[Json]
		// [Key]
		public List<Stage> Stages;
		[Json]
		// [Key]
		public Dictionary<DifficultyId, Dictionary<int, UserPrize>> StoryRewardsByStarsByDifficulty;
		[Json]
		// [Key]
		public Dictionary<RegionTypeId, RegionPassData> RegionPassDataById;
		[Json]
		// [Key]
		public StageSettings Settings;
		[Json]
		// [Key]
		public RewardsOrderId[] FirstTimeRewardOrder;
		[Json]
		// [Key]
		public Dictionary<int, UserPrize> FractionWarRewardsByStars;
		[Json]
		// [Key]
		public UserPrize FractionWarMainReward;
		[IgnoreMember]
		[JsonSkip]
		private List<Region> _regions;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<AreaTypeId, Area> AreasById;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, Stage> StagesById;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<DifficultyId, List<int>> StoryStageIdsByDifficulty;
		[IgnoreMember]
		[JsonSkip]
		public int ArenaUserLevelRequired;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public List<Region> Regions { get => default; }
	
		// Constructors
		public StaticStageData() {}
	
		// Methods
		public void Cache(StaticHeroData heroData) {}
		public Stage GetStageById(int typeId, bool throwExceptionIfNotFound = true) => default;
		public Stage GetNextStage(Stage stage) => default;
		public Stage GetPrevStage(Stage stage, UserAbTestData userAbTestData = null, DateTime? now = default) => default;
		private Stage GetPrevStageForA(Stage stage) => default;
		private Stage GetPrevStageForB(Stage stage) => default;
		public static int BuildStageId(AreaTypeId areaTypeId, RegionTypeId regionTypeId, DifficultyId difficultyId, int number) => default;
	}
}
