
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Setup;
using SharedModel.Meta.GlobalEvents.Entities;
using SharedModel.Meta.Quests.Completions;



namespace SharedModel.Meta.Tournaments
{
	public static class BattleSetupExtensions
	{
		// Methods
		private static int PointsByDungeon(BattleSetup setup, IEnumerable<GlobalEventRule> rules) => default;
		private static int PointsByStory(BattleSetup setup, IEnumerable<GlobalEventRule> rules) => default;
		private static int PointsByArena(BattleSetup setup, IEnumerable<GlobalEventRule> rules) => default;
	
		// Extension methods
		public static bool TryCalculateTournamentPoints(this BattleSetup setup, QuestCompletion completion, out int points) {
			points = default;
			return default;
		}
		public static IEnumerable<GlobalEventRule> AreaRulesFor(this BattleSetup setup, QuestCompletion completion) => default;
	}
}
