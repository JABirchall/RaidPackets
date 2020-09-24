
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Heroes.Dtos;



namespace SharedModel.Meta.Shards
{
	public static class ShardExtensions
	{
		// Fields
		public static Dictionary<ShardTypeId, List<ShardDropRule>> ShardDropRulesDefault;
	
		// Constructors
		static ShardExtensions() {}
	
		// Methods
		private static Dictionary<ShardTypeId, List<ShardDropRule>> BuildShardDropRules() => default;
	
		// Extension methods
		public static IUndoState AddShard(this UserShardData data, ShardTypeId typeId, int count = 1) => default;
		public static Shard GetShard(this UserShardData data, ShardTypeId typeId) => default;
		public static UserShardData TakeShardFromUser(this UserShardData data, ShardTypeId typeId, int count = 1) => default;
		public static UserShardData TakeShardFromUser(this UserShardData data, Shard shard, int count = 1) => default;
		public static ShardSummonResult GetSummonResult(this UserShardData data, ShardTypeId typeId, HeroRarity rarity) => default;
		public static ShardSummonResult GetOrAddSummonResult(this UserShardData data, ShardTypeId typeId, HeroRarity rarity) => default;
		public static void AddSummonResult(this UserShardData data, ShardType shardType, HeroType heroType) {}
		public static bool HasShard(this UserShardData data, ShardTypeId shardTypeId) => default;
		public static bool Exists(this Shard shard) => default;
		public static bool IsEnough(this Shard shard, int count = 1) => default;
		public static bool IsValidSummonCount(this SummonHeroesRequestDto request) => default;
		public static bool IsMystery(this ShardTypeId shardTypeId) => default;
		public static bool IsAncient(this ShardTypeId shardTypeId) => default;
		public static bool IsLegendary(this ShardTypeId shardTypeId) => default;
		public static bool IsVoid(this ShardTypeId shardTypeId) => default;
		public static Shard AssertExists(this Shard shard) => default;
		public static Shard AssertIsEnough(this Shard shard, int count = 1) => default;
		public static SummonHeroesRequestDto AssertIsValidSummonCount(this SummonHeroesRequestDto request) => default;
		public static bool IsValidRarities(this List<ShardDropRule> dropRules, ShardTypeId shardTypeId) => default;
		public static bool IsValidSum(this List<ShardDropRule> dropRules) => default;
		public static bool IsValidValues(this List<ShardDropRule> dropRules, ShardTypeId shardTypeId) => default;
		public static bool IsValid(this List<ShardDropRule> dropRules, ShardTypeId shardTypeId) => default;
		private static bool Invalid(this ShardDropRule inputRule, ShardTypeId typeId) => default;
	}
}
