
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.ServerEvents;



namespace SharedModel.Meta.Shards
{
	[MessagePackObject]
	public class ShardDropRule : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public HeroRarity Rarity;
		[Json]
		// [Key]
		public double Chance;
		[Json]
		// [Key]
		public double? ChanceIncreaseOnEachTry;
		[Json]
		// [Key]
		public int? ChanceIncreaseSummonNumber;
		[Json]
		// [Key]
		public bool? DenyRepeatLast;
		[Json]
		// [Key]
		public ImprovementId? Improvement;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool DenyRepeat { get => default; }
	
		// Constructors
		public ShardDropRule() {}
		public ShardDropRule(HeroRarity rarity, double chance, double? chanceIncrease = default, int? summonNumber = default, bool? denyRepeatLast = default) {}
	
		// Methods
		public ShardDropRule Clone() => default;
		public void IncreaseChance(double chance) {}
		public void DecreaseChance(double chance) {}
		public double TryIncreaseChance(ShardTypeId shardTypeId, UserShardData shardData) => default;
		public int CalcHash() => default;
	}
}
