
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Setup;



namespace SharedModel.Meta.Battle.Arena
{
	public static class ArenaExtensions
	{
		// Methods
		public static DateTime GetPrevTournamentEndTime(DateTime now) => default;
		public static DateTime GetTournamentEndTime(DateTime now) => default;
		public static TimeSpan GetTournamentTimeLeft(DateTime now) => default;
	
		// Extension methods
		public static ArenaOpponent FindOpponent(this UserArenaData data, long userId, bool rated) => default;
		public static ArenaLeagueId CalcLeagueId(this UserArenaData data, long userId, int userLevel) => default;
		public static ArenaLeagueId GetLeagueIdByPoints(this StaticArenaData staticData, long points) => default;
		public static UserArenaData AddArenaPoints(this UserArenaData data, long arenaPoints) => default;
		public static bool IsOpponentOnCooldown(this UserArenaData data, ArenaOpponent opponent, long userId, int userLevel) => default;
		public static bool IsSuitableArenaTeam(this TeamSetup setup) => default;
		public static ArenaOpponent AssertNotDefeated(this ArenaOpponent opponent) => default;
	}
}
