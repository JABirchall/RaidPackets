
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Quests.Completions;
using SharedModel.Meta.Quests.Data;
using SharedModel.Meta.Quests.RecommendedQuests;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Quests
{
	public static class QuestExtensions
	{
		// Extension methods
		public static UserQuestData AddState(this UserQuestData data, QuestState state) => default;
		public static UserQuestData RemoveStateAt(this UserQuestData data, int index) => default;
		public static bool IsCompleted(this QuestState questState) => default;
		public static bool IsPrizeClaimed(this QuestState questState) => default;
		public static bool IsChallengeV1QuestState(this QuestState state) => default;
		public static bool IsRecommendedQuest(this QuestState state) => default;
		public static bool IsTournament(this QuestState state) => default;
		public static bool IsObsoleteNoviceTournament(this QuestState state) => default;
		public static bool IsCommonNoviceTournament(this QuestState state) => default;
		public static bool IsOldInfluencersTournament(this QuestState state) => default;
		public static bool IsCommonTournament(this QuestState state) => default;
		public static bool IsGlobalEventSoloQuest(this QuestState state) => default;
		public static bool IsBattlePassQuest(this QuestState state) => default;
		public static bool HasState(this UserQuestData data, int prototypeId) => default;
		public static bool HasStateByQuestId(this UserQuestData data, int questId) => default;
		public static bool HasInProgressState(this UserQuestData data, int prototypeId) => default;
		public static bool HasCompletedState(this UserQuestData data, int prototypeId) => default;
		private static UserQuestData AssertOpenedStatesIndexIsValid(this UserQuestData data, int index) => default;
		public static QuestState GetQuestStateById(this UserQuestData userQuestData, int questId) => default;
		public static QuestState AssertHasQuestStateById(this UserQuestData userQuestData, int questId) => default;
		public static QuestState AssertIsCompleted(this QuestState state) => default;
		public static void AssertRecommendedQuestGroupCompleted(this UserRecommendedQuestData questData, List<int> lastPrototypeIds) {}
		public static QuestState GetQuestStateByPrototypeId(this UserQuestData userQuestData, int prototypeId) => default;
		public static QuestState AssertHasQuestByPrototypeId(this UserQuestData userQuestData, int prototypeId) => default;
		public static bool IsGlobalEventSolo(this Quest quest) => default;
		public static bool IsCommonTournament(this Quest quest) => default;
		public static QuestCompletion GetGlobalEventCompletion(this QuestState state) => default;
		public static QuestCompletionByTournament GetTournamentCompletion(this QuestState state) => default;
		public static List<QuestCompletion> GetGlobalEventCompletions(this QuestState state) => default;
		public static QuestCompletionByTournament ByTournament(this List<QuestCompletion> completions) => default;
		public static UserPrizeSource ToUserPrizeSource(this QuestCategoryId categoryId) => default;
	}
}
