
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByArena
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
		public bool? InARow;
		[Json]
		// [Key]
		public bool? CountLastButOneLeague;
		[Json]
		// [Key]
		public bool? OnlyWonBattles;
		[Json]
		// [Key]
		public bool? OnlyDefBattles;
		[Json]
		// [Key]
		public bool? GetRevenge;
		[Json]
		// [Key]
		public bool? NoDeaths;
		[Json]
		// [Key]
		public bool? KillEnemyDuringFirstTurn;
		[Json]
		// [Key]
		public bool? EarnPoints;
		[Json]
		// [Key]
		public ArenaQuestAction? Action;
		[Json]
		// [Key]
		public HeroGrade? HeroGrade;
		[Json]
		// [Key]
		public ArenaLeagueId? LeagueId;
		[Json]
		// [Key]
		public ResourceTypeId? ResourceTypeId;
		[Json]
		// [Key]
		public int? ArenaPoints;
	
		// Constructors
		public QuestCompletionByArena() {}
	
		// Methods
		public bool IsCompleted(long userId, int userLevel, UserArenaData arenaData, UserHeroData heroData) => default;
		public QuestCompletionProgress CalcProgress(long userId, int userLevel, UserArenaData arenaData, UserHeroData heroData) => default;
		public QuestCompletionByArena Clone() => default;
	}
}
