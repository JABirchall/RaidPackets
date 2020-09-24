
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class ShardsData : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId TypeId;
		[Json]
		// [Key]
		public List<ShardDropRule> DropRules;
	
		// Constructors
		public ShardsData() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
