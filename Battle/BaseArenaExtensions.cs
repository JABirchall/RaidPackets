
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Battle.Arena;



namespace SharedModel.Meta.Battle
{
	public static class BaseArenaExtensions
	{
		// Methods
		public static long CalcWinPoints(long ownPoints, long opponentPoints) => default;
		public static long CalcLoosePoints(long ownPoints, long opponentPoints) => default;
		private static double CalcKFactor(double points, double opponentPoints) => default;
	
		// Extension methods
		public static bool IsBronze(this ArenaLeagueId leagueId) => default;
		public static bool IsSilver(this ArenaLeagueId leagueId) => default;
		public static bool IsGold(this ArenaLeagueId leagueId) => default;
		public static bool IsPlatinum(this ArenaLeagueId leagueId) => default;
		public static UserArenaData UpdateLastRewardTime(this UserArenaData data, DateTime now) => default;
		public static ArenaLeagueInfo GetLeagueInfo(this StaticArenaData staticData, ArenaLeagueId leagueId) => default;
		public static UserArenaData UpdateParticipationDate(this UserArenaData data, DateTime now) => default;
		public static ArenaLeagueId GetNextLeagueId(this StaticArenaData staticData, ArenaLeagueId leagueId) => default;
		public static ArenaLeagueInfo GetNextLeagueInfo(this StaticArenaData staticData, ArenaLeagueId leagueId) => default;
		public static ArenaLeagueId GetPreviousLeagueId(this StaticArenaData staticData, ArenaLeagueId leagueId) => default;
		public static bool IsLast(this ArenaLeagueId leagueId) => default;
		public static ArenaLeagueInfo GetPreviousLeagueInfo(this StaticArenaData staticData, ArenaLeagueId leagueId) => default;
		public static UserArenaData SetArenaPoints(this UserArenaData data, long arenaPoints) => default;
		public static UserArenaData SetArenaDefense(this UserArenaData data, int[] heroIds) => default;
		public static IUndoState UpdateArenaDefenceHeroes(this UserArenaData data, int obsoleteHeroId, int newHeroId) => default;
		public static bool HasDefense(this UserArenaData data) => default;
		public static UserArenaData AssertHasDefense(this UserArenaData data) => default;
		public static UserArenaData AssertHasOpponents(this UserArenaData data) => default;
		public static UserArenaData AssertHeroNotInDefense(this UserArenaData data, int heroId) => default;
	}
}
