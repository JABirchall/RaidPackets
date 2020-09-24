
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class QuestSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool SkipWizard;
		[Json]
		// [Key]
		public bool SkipFeatureWizard;
		[Json]
		// [Key]
		public bool SkipStoryline;
		[Json]
		// [Key]
		public bool ChallengesV2Enabled;
		[Json]
		// [Key]
		public bool ChallengesV3Enabled;
		[Json]
		// [Key]
		public Dictionary<QuestCategoryId, bool> GivePrizeFromPrototypeByQuestCategoryId;
		[Json]
		// [Key]
		public bool AchievementsEnabled;
		[Json]
		// [Key]
		public bool RecommendedQuestsEnabled;
		[Json]
		// [Key]
		public int LastStageForGroup1RecommendedQuests;
		[Json]
		// [Key]
		public bool AchievementsReBalanceEnabled;
	
		// Constructors
		public QuestSettings() {}
	}
}
