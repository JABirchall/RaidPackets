
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
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class ArenaLog
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public DateTime Time;
		[Json]
		// [Key]
		public long OpponentPoints;
		[Json]
		// [Key]
		public List<long> OpponentPoints3X3;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public long PointsGained;
		[Json]
		// [Key]
		public TeamSetup OpponentSetup;
		[Json]
		// [Key]
		public List<TeamSetup> Opponent3X3Setup;
		[Json]
		// [Key]
		public List<long> PointsGained3X3;
		[Json]
		// [Key]
		public bool Victory;
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public bool OpponentInitiated;
		[Json]
		// [Key]
		public bool Rated;
		[Json]
		// [Key]
		public InfluencerInfo InfluencerInfo;
		[Json]
		// [Key]
		public List<ArenaOpponentStatus> Arena3X3Results;
	
		// Constructors
		public ArenaLog() {}
		public ArenaLog(long userId, DateTime time, long opponentPoints, UserPrize prize, long pointsGained, TeamSetup opponentSetup, bool victory, string name, bool isOpponentInitiated, bool rated = true, InfluencerInfo influencerInfo = null) {}
		public ArenaLog(long userId, DateTime time, long opponentPoints, UserPrize prize, long pointsGained, List<TeamSetup> opponentSetup, bool victory, string name, bool isOpponentInitiated, bool rated = true, InfluencerInfo influencerInfo = null, List<ArenaOpponentStatus> statuses = null) {}
		public ArenaLog(long userId, DateTime time, long opponentPoints, List<long> opponentPoints3X3, UserPrize prize, List<long> pointsGained, List<TeamSetup> opponentSetup, bool victory, string name, bool isOpponentInitiated, bool rated = true, InfluencerInfo influencerInfo = null, List<ArenaOpponentStatus> statuses = null) {}
	}
}
