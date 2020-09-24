
using System;
using System.Collections.Generic;
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
	public class ShardSettings
	{
		// Fields
		[Json]
		// [Key]
		public int[] SummonHeroIds;
		[Json]
		// [Key]
		public int MysteryClickerUserLevelLimit;
		[Json]
		// [Key]
		public bool MultiSummonEnabled;
		[Json]
		// [Key]
		public bool ShowDropRate;
		[Json]
		// [Key]
		public Dictionary<ShardTypeId, List<ShardDropRule>> ShardDropRules;
		[Json]
		// [Key]
		public Dictionary<ShardTypeId, int[]> DisabledHeroIdsByShardTypeId;
	
		// Constructors
		public ShardSettings() {}
	
		// Methods
		public bool IsDropForbidden(ShardTypeId typeId, HeroType hero) => default;
	}
}
