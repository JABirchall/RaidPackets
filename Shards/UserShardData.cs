
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
	public class UserShardData
	{
		// Fields
		[Json]
		// [Key]
		public List<Shard> Shards;
		[Json]
		// [Key]
		public List<ShardSummonResult> SummonResults;
	
		// Constructors
		public UserShardData() {}
	}
}
