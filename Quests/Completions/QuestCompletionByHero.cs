
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Heroes.Entities;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByHero
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
		public int? Level;
		[Json]
		// [Key]
		public int? HeroTypeId;
		[Json]
		// [Key]
		public HeroQuestAction? Action;
		[Json]
		// [Key]
		public HeroLevelUpSource? LevelUpSource;
		[Json]
		// [Key]
		public HeroRarity? Rarity;
		[Json]
		// [Key]
		public HeroGrade? Grade;
		[Json]
		// [Key]
		public Element? Element;
		[Json]
		// [Key]
		public HeroRole? Role;
		[Json]
		// [Key]
		public ShardTypeId? ShardTypeId;
		[Json]
		// [Key]
		public int? AwakeLevel;
		[Json]
		// [Key]
		public int? SkillLevel;
		[Json]
		// [Key]
		public bool? GreaterOrEqual;
		[Json]
		// [Key]
		public bool? LevelUpAllSkills;
		[Json]
		// [Key]
		public bool? CollectHeroesFromAllFractions;
		[Json]
		// [Key]
		public int? ArtifactsLevel;
		[Json]
		// [Key]
		public int? ArtifactsCount;
		[Json]
		// [Key]
		public bool? MaterialIsBlackMarketItem;
		[Json]
		// [Key]
		public bool? MaterialIsSameHero;
		[Json]
		// [Key]
		public bool? CountEachLevel;
		[Json]
		// [Key]
		public Dictionary<HeroFraction, int> AscendAllFractionHeroes;
		[Json]
		// [Key]
		public Dictionary<Element, int> AscendAllElementHeroes;
	
		// Constructors
		public QuestCompletionByHero() {}
	
		// Methods
		public bool IsDone(UserHeroData readData, DateTime now) => default;
		public bool IsCompleted(UserHeroData readData) => default;
		public QuestCompletionProgress CalcProgress(UserHeroData readData) => default;
		private bool CompareStats(Hero hero) => default;
		public QuestCompletionByHero Clone() => default;
	}
}
