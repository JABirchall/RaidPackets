
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Shards
{
	[MessagePackObject]
	public class ShardSummonResult
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId ShardTypeId;
		[Json]
		// [Key]
		public HeroRarity Rarity;
		[Json]
		// [Key]
		public int Count;
		[Json]
		// [Key]
		public int LastHeroId;
	
		// Constructors
		public ShardSummonResult() {}
		public ShardSummonResult(ShardTypeId shardTypeId, HeroRarity rarity) {}
	}
}
