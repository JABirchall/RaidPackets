
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Shards
{
	[MessagePackObject]
	public class StaticShardData
	{
		// Fields
		[Json]
		// [Key]
		public ShardSettings ShardSettings;
		[Json]
		// [Key]
		public List<ShardType> ShardTypes;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ShardTypeId, ShardType> _shardTypesById;
	
		// Constructors
		public StaticShardData() {}
	
		// Methods
		public void Cache() {}
		public bool HasShardType(ShardTypeId typeId) => default;
		public ShardType GetShardType(ShardTypeId typeId, bool throwExceptionIfNotFound = true) => default;
		public DynamicShardData ToDynamicData() => default;
	}
}
