
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.AbTests
{
	[MessagePackObject]
	public class ShardImproveInfo
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId ShardTypeId;
		[Json]
		// [Key]
		public int Tries;
		[Json]
		// [Key]
		public double IncreaseChance;
		[Json]
		// [Key]
		public double IncreaseChanceCap;
	
		// Constructors
		public ShardImproveInfo() {}
		public ShardImproveInfo(ShardTypeId shardTypeId, int tries, double increaseChance, double increaseChanceCap) {}
	}
}
