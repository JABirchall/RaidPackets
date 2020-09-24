
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class BattleStatsModifier : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Round;
		[Json]
		// [Key]
		public StatKindId KindId;
		[Json]
		// [Key]
		public double Value;
		[Json]
		// [Key]
		public bool IsAbsolute;
		[Json]
		// [Key]
		public bool BossOnly;
	
		// Constructors
		public BattleStatsModifier() {}
		public BattleStatsModifier(int round, StatKindId kindId, double value, bool isAbsolute, bool bossOnly) {}
	
		// Methods
		public BattleStatsModifier Clone() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(BattleStatsModifier other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
