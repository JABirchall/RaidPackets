
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
	public class HeroesData : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, int> HeroWeightByTypeId;
		[Json]
		// [Key]
		public ShardTypeId ShardTypeId;
	
		// Constructors
		public HeroesData() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
