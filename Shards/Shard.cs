
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Shards
{
	[MessagePackObject]
	public class Shard
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId TypeId;
		[Json]
		// [Key]
		public int Count;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public ShardType Type { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public ShardType NewbieType { get => default; }
	
		// Constructors
		public Shard() {}
		public Shard(ShardTypeId typeId, int count) {}
	
		// Methods
		public Shard Clone() => default;
		public override int GetHashCode() => default;
	}
}
