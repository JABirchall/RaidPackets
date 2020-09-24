
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Setup;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class BattleStatsModifierSetup : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public BattleStats PercentBonus;
		[Json]
		// [Key]
		public BattleStats FlatBonus;
		[Json]
		// [Key]
		public InitialState InitialState;
	
		// Constructors
		public BattleStatsModifierSetup() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(BattleStatsModifierSetup other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
