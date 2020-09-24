
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
	public class DynamicShardData
	{
		// Fields
		[JsonSkip]
		private List<ShardType> _shardTypes;
		[JsonSkip]
		private Dictionary<ShardTypeId, ShardType> _shardTypesById;
		[JsonSkip]
		private List<ShardType> _newbieShardTypes;
		[JsonSkip]
		private Dictionary<ShardTypeId, ShardType> _newbieShardTypesById;
	
		// Properties
		[Json]
		// [Key]
		public List<ShardType> ShardTypes { get => default; set {} }
		[Json]
		// [Key]
		public List<ShardType> NewbieShardTypes { get => default; set {} }
	
		// Constructors
		public DynamicShardData() {}
		public DynamicShardData(List<ShardType> shardTypes, List<ShardType> newbieShardTypes) {}
		public DynamicShardData(List<ShardType> shardTypes) {}
	
		// Methods
		public ShardType GetShardType(ShardTypeId typeId, bool throwExceptionIfNotFound = true) => default;
		public ShardType GetShardTypeForNewbie(ShardTypeId typeId, bool throwExceptionIfNotFound = true) => default;
		private void InitializeForNewbies(List<ShardType> newbieShardTypes) {}
		private void Initialize(List<ShardType> shardTypes, List<ShardType> newbieShardTypes = null) {}
	}
}
