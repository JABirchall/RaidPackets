
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Battle.Arena
{
	public interface IArenaLeagueEvaluator
	{
		// Methods
		ArenaLeagueId CalcLeagueId(long userId, UserArenaData arenaData, int userLevel);
	}
}
