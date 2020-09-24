
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests.Data.UserData;
using SharedModel.Meta.Quests.RecommendedQuests;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class UserQuestData
	{
		// Fields
		[Json]
		// [Key]
		public int LastQuestId;
		[Json]
		// [Key]
		public List<QuestState> OpenedStates;
		[Json]
		// [Key]
		public UserQuestDataFeature FeatureData;
		[Json]
		// [Key]
		public UserQuestDataFluent FluentData;
		[Json]
		// [Key]
		public UserQuestDataPeriodic PeriodicData;
		[Json]
		// [Key]
		public UserQuestDataChallenges ChallengesData;
		[Json]
		// [Key]
		public UserQuestDataAchievements AchievementsData;
		[Json]
		// [Key]
		public UserRecommendedQuestData RecommendedQuestsData;
		[Json]
		// [Key]
		public UserQuestDataGlobalEvent GlobalEventsData;
		[Json]
		// [Key]
		public UserQuestDataNoviceTournament NoviceTournamentData;
		[Json]
		// [Key]
		public UserQuestDataInfluencerTournament InfluencerTournamentData;
		[Json]
		// [Key]
		public UserQuestBattlePassData BattlePassData;
		[Json]
		// [Key]
		public UserQuestAdvancedDailyData AdvancedDailyData;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool WinFirstBattleQuestCompleted { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool WinSecondBattleQuestCompleted { get => default; }
	
		// Constructors
		public UserQuestData() {}
	
		// Methods
		public bool CompletedGlobalEvent(int prototypeId) => default;
	}
}
