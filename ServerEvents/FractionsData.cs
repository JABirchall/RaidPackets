
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.ServerEvents
{
	[MessagePackObject]
	public class FractionsData : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public HeroFraction FractionId;
		[Json]
		// [Key]
		public List<ShardTypeId> AvailableShards;
		[Json]
		// [Key]
		public int Weight;
	
		// Constructors
		public FractionsData() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
