
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Hero;
using SharedModel.Battle.Effects;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class BattleStats : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public Fixed Health;
		[Json]
		// [Key]
		public Fixed Attack;
		[Json]
		// [Key]
		public Fixed Defence;
		[Json]
		// [Key]
		public Fixed Speed;
		[Json]
		// [Key]
		public Fixed Resistance;
		[Json]
		// [Key]
		public Fixed Accuracy;
		[Json]
		// [Key]
		public Fixed CriticalChance;
		[Json]
		// [Key]
		public Fixed CriticalDamage;
		[Json]
		// [Key]
		public Fixed CriticalHeal;
		public static readonly BattleStats Empty;
		private static readonly Fixed ToPercent;
		private static readonly double[,] Multipliers;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Fixed Weight { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Fixed this[StatKindId statKindId] { get => default; }
	
		// Constructors
		public BattleStats() {}
		public BattleStats(BattleStats stats) {}
		public BattleStats(int health, int attack, int defence, int speed, int resistance, int accuracy, int criticalChance, int criticalDamage) {}
		static BattleStats() {}
	
		// Methods
		public bool AllLessThan(Fixed value) => default;
		public bool AnyLessThan(Fixed value) => default;
		public bool AnyLessThanOrEqual(Fixed value) => default;
		public bool AllGreaterThan(Fixed value) => default;
		public bool AnyGreaterThan(Fixed value) => default;
		public bool GreaterThanOrEqualTo(BattleStats other) => default;
		public void Change(StatKindId statKindId, OperationType operationType, Fixed value) {}
		public void Change(OperationType operationType, BattleStats otherStats) {}
		public static void ChangeStats(BattleStats stats, OperationType operationType, BattleStats other) {}
		public static BattleStats OperatedStats(OperationType operationType, params BattleStats[] operans) => default;
		public static BattleStats Operation(OperationType operationType, params BattleStats[] battleStatsOperands) => default;
		public static BattleStats Operation(BattleStats firstStats, OperationType operationType, BattleStats secondStats) => default;
		private static Fixed Operation(OperationType operationType, params Fixed[] battleStatsOperands) => default;
		private static Fixed Operation(Fixed firstValue, OperationType operationType, Fixed secondValue) => default;
		public void UpdateWithBonuses(BattleStats lp, BattleStats lf, BattleStats arena, BattleStats bp, BattleStats bf, BattleStats ap, BattleStats af, BattleStats mp, BattleStats mf) {}
		public void UpdateWithBonuses(BattleBonuses battleBonuses) {}
		private Fixed CalcAbsoluteStats(Fixed @base, Fixed lp, Fixed lf, Fixed arena, Fixed bp, Fixed bf, Fixed ap, Fixed af, Fixed mp, Fixed mf) => default;
		private Fixed CalcPercentageStats(Fixed @base, Fixed lp, Fixed lf, Fixed bp, Fixed bf, Fixed ap, Fixed af, Fixed mp, Fixed mf) => default;
		public BattleStats BuildFromBase(HeroGrade grade, int level) => default;
		private static Fixed CalcValue(Fixed baseStat, HeroGrade heroGrade, int level) => default;
		public void Validate(string error) {}
		public bool IsEmpty() => default;
		public BattleStats Clone() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(BattleStats other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
		public string ToStringExt(bool inOneRow = false) => default;
	}
}
