
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Battle.Arena;



namespace SharedModel.Meta.Stages
{
	public static class Arena3X3StageId
	{
		// Fields
		private static int _bronzeLeagueStageId;
		private static int _silverLeagueStageId;
		private static int _goldLeagueStageId;
	
		// Constructors
		static Arena3X3StageId() {}
	
		// Methods
		public static int Get(ArenaLeagueId leagueId) => default;
	}
}
