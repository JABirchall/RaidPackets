
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Battle.Arena;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventArenaRule
	{
		// Fields
		[Json]
		// [Key]
		public ArenaLeagueId LeagueId;
	
		// Constructors
		public GlobalEventArenaRule() {}
	
		// Methods
		public bool Satisfies(ArenaLeagueId leagueId) => default;
		public GlobalEventArenaRule Clone() => default;
	}
}
