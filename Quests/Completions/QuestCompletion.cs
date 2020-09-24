
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletion
	{
		// Fields
		[Json]
		// [Key]
		public QuestCompletionStateId StateId;
		[Json]
		// [Key]
		public QuestCompletionByClient ByClient;
		[Json]
		// [Key]
		public QuestCompletionByAction ByAction;
		[Json]
		// [Key]
		public QuestCompletionPeriodic Periodic;
		[Json]
		// [Key]
		public QuestCompletionByBattle ByBattle;
		[Json]
		// [Key]
		public QuestCompletionByArtifact ByArtifact;
		[Json]
		// [Key]
		public QuestCompletionByQuest ByQuest;
		[Json]
		// [Key]
		public QuestCompletionByHero ByHero;
		[Json]
		// [Key]
		public QuestCompletionByCapitolBonus ByCapitolBonus;
		[Json]
		// [Key]
		public QuestCompletionByArena ByArena;
		[Json]
		// [Key]
		public QuestCompletionByLoot ByLoot;
		[Json]
		// [Key]
		public QuestCompletionByMastery ByMastery;
		[Json]
		// [Key]
		public QuestCompletionByFuse ByFuse;
		[Json]
		// [Key]
		public QuestCompletionByAllianceActivity ByAllianceActivity;
		[Json]
		// [Key]
		public QuestCompletionBySoloEvent BySoloEvent;
		[Json]
		// [Key]
		public QuestCompletionByTournament ByTournament;
		[Json]
		// [Key]
		public QuestCompletionByResourceSpent ByResourceSpent;
		[Json]
		// [Key]
		public QuestCompletionByForge ByForge;
	
		// Constructors
		public QuestCompletion() {}
	
		// Methods
		public QuestCompletion Clone() => default;
		public void Replace(QuestCompletion with) {}
	}
}
