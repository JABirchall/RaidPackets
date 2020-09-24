
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.PeriodicQuests.Data
{
	[MessagePackObject]
	public class PeriodicQuestFilter
	{
		// Fields
		[Json]
		// [Key]
		public PeriodicQuestPrototypeId PrototypeId;
		[Json]
		// [Key]
		public HeroGrade? HeroGrade;
		[Json]
		// [Key]
		public int? ArtifactLevel;
		[Json]
		// [Key]
		public List<BlackMarketItemId> BlackMarketItemIds;
		[Json]
		// [Key]
		public List<QuestCategoryId> QuestCategoryIds;
		[Json]
		// [Key]
		public List<QuestCategoryId> QuestCategoryIgnoredIds;
		[Json]
		// [Key]
		public List<PeriodicQuestGroupId> PeriodicQuestGroupIds;
		[Json]
		// [Key]
		public List<int> QuestPrototypeIds;
	
		// Constructors
		public PeriodicQuestFilter() {}
	
		// Methods
		public PeriodicQuestFilter Clone() => default;
	}
}
