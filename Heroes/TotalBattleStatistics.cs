
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class TotalBattleStatistics
	{
		// Fields
		[Json]
		// [Key]
		public int DamageDealt;
		[Json]
		// [Key]
		public int CalculatedDamage;
		[Json]
		// [Key]
		public int ShieldDamage;
		[Json]
		// [Key]
		public int DamageTaken;
		[Json]
		// [Key]
		public int PureDamageTaken;
		[Json]
		// [Key]
		public int ShieldDamageTaken;
		[Json]
		// [Key]
		public int RestoredHp;
		[Json]
		// [Key]
		public int PureRestoredHp;
		[Json]
		// [Key]
		public int Shield;
		[Json]
		// [Key]
		public Dictionary<StatusEffectTypeId, int> AppliedStatusEffects;
		[Json]
		// [Key]
		public Dictionary<int, int> SkillUsedCountById;
	
		// Constructors
		public TotalBattleStatistics() {}
	
		// Methods
		public TotalBattleStatistics Clone() => default;
		public void Add(TotalBattleStatistics other) {}
		public string GetStats(bool inOneRow = false) => default;
		public string GetAppliedEffects(bool inOneRow = false) => default;
		public string GetSkillUsed(HeroType hero, bool inOneRow = false) => default;
	}
}
