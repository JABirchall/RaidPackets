
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
	public class OpenShardsDto
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId TypeId;
		[Json]
		// [Key]
		public int Count;
	
		// Constructors
		public OpenShardsDto() {}
		public OpenShardsDto(ShardTypeId typeId, int count) {}
	}
}
