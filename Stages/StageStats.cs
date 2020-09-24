
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Result;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class StageStats
	{
		// Fields
		[Json]
		// [Key]
		public bool Passed;
		[Json]
		// [Key]
		public int BestTimeInSeconds;
		[Json]
		// [Key]
		public int Stars;
		[Json]
		// [Key]
		public Dictionary<BattleResultType, int> BattleResults;
		[Json]
		// [Key]
		public DateTime LastBattleTime;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int TotalBattles { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int Victories { get => default; }
	
		// Constructors
		public StageStats() {}
	
		// Methods
		public void RecordBattle(BattleResultType type, DateTime time) {}
		public static StageStats Default() => default;
	}
}
