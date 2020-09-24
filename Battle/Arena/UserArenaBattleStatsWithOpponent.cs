
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class UserArenaBattleStatsWithOpponent
	{
		// Fields
		[Json]
		// [Key]
		public int BattleCount;
		[Json]
		// [Key]
		public DateTime LastBattleTime;
	
		// Constructors
		public UserArenaBattleStatsWithOpponent() {}
	}
}
