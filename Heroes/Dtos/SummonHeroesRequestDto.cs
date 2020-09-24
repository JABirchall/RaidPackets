
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Shards;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class SummonHeroesRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId ShardTypeId;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public SummonHeroesRequestDto() {}
	}
}
