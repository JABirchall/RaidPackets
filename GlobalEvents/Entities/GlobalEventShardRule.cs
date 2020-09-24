
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventShardRule
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId TypeId;
	
		// Constructors
		public GlobalEventShardRule() {}
	
		// Methods
		public bool Satisfies(ShardType shard) => default;
		public GlobalEventShardRule Clone() => default;
	}
}
