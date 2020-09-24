
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core;



namespace SharedModel.Meta.Users
{
	public static class GameParametersExtensions
	{
		// Methods
		public static GameParameters FakeGameParameters() => default;
	
		// Extension methods
		public static bool NewEngineEnabled(this GameParameters parameters, EngineVersion currentEngineVersion) => default;
		public static bool TournamentsEnabled(this GameParameters parameters) => default;
	}
}
