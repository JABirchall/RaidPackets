
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Setup;
using SharedModel.Meta.Tournaments;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class ArenaOpponent
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public ArenaOpponentStatus Status;
		[Json]
		// [Key]
		public long ArenaPoints;
		[Json]
		// [Key]
		public TeamSetup TeamSetup;
		[Json]
		// [Key]
		public DateTime? VictoryTime;
		[Json]
		// [Key]
		public InfluencerInfo InfluencerInfo;
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public bool Rated;
		[Json]
		// [Key]
		public List<TeamSetup> MultiTeamSetup;
		[Json]
		// [Key]
		public List<ArenaOpponentStatus> MultiStatus;
		[Json]
		// [Key]
		public List<int> Arena3X3VictoryPoints;
		[Json]
		// [Key]
		public int BattleNumberInARow;
		[Json]
		// [Key]
		public List<BattleSetup> Setups;
	
		// Constructors
		public ArenaOpponent() {}
		public ArenaOpponent(long userId, long arenaPoints, TeamSetup teamSetup, string name, InfluencerInfo influencerInfo = null, bool rated = true) {}
		public ArenaOpponent(long userId, long arenaPoints, List<TeamSetup> teamSetups, string name, InfluencerInfo influencerInfo = null, bool rated = true) {}
	
		// Methods
		public ArenaOpponent Add3X3Status(int battleIndex, ArenaOpponentStatus status) => default;
		public ArenaOpponent Clone() => default;
	}
}
