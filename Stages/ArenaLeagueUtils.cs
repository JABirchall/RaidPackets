
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Battle.Arena;



namespace SharedModel.Meta.Stages
{
	public static class ArenaLeagueUtils
	{
		// Fields
		private static int _bronzeLeagueStageId;
		private static int _silverLeagueStageId;
		private static int _goldLeagueStageId;
		private static int _platinumLeagueStageId;
	
		// Constructors
		static ArenaLeagueUtils() {}
	
		// Methods
		public static int GetStageId(ArenaLeagueId league) => default;
	}
}
