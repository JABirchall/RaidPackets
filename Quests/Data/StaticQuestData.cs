
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests.Data;
using SharedModel.Meta.Quests.AdvancedDailyQuests;
using SharedModel.Meta.Quests.RecommendedQuests;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class StaticQuestData
	{
		// Fields
		[Json]
		// [Key]
		public StaticPeriodicQuestData PeriodicQuestData;
		[Json]
		// [Key]
		public ChallengeQuestData ChallengeQuestData;
		[Json]
		// [Key]
		public RecommendedQuestData RecommendedQuestData;
		[Json]
		// [Key]
		public AdvancedDailyQuestData AdvancedDailyQuestData;
		[Json]
		// [Key]
		public QuestSettings Settings;
		[IgnoreMember]
		[JsonSkip]
		public const int MaxFactoryPrototypesCount = 50000;
		[IgnoreMember]
		[JsonSkip]
		public const int MaxDynamicFactoryPrototypesCount = 1000000;
		[IgnoreMember]
		[JsonSkip]
		public const int WizardSummonHeroId = 2120;
		[IgnoreMember]
		[JsonSkip]
		public const int WizardUpgradeArtifactToLevel = 4;
		[IgnoreMember]
		[JsonSkip]
		public static readonly int WizardSummonHeroPrototypeId;
		[IgnoreMember]
		[JsonSkip]
		public static readonly int WizardCompleteFirstBattleQuestId;
		[IgnoreMember]
		[JsonSkip]
		public static readonly int WizardCompleteSecondBattleQuestId;
	
		// Constructors
		public StaticQuestData() {}
		static StaticQuestData() {}
	
		// Methods
		public void Cache() {}
	}
}
