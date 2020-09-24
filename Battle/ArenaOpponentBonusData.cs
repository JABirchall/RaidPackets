
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Battle
{
	[MessagePackObject]
	public class ArenaOpponentBonusData
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public long OpponentId;
		[Json]
		// [Key]
		public AreaTypeId AreaTypeId;
		[Json]
		// [Key]
		public string Bonuses;
	
		// Constructors
		public ArenaOpponentBonusData() {}
		public ArenaOpponentBonusData(long userId, long opponentId, AreaTypeId areaTypeId, string bonuses) {}
	}
}
