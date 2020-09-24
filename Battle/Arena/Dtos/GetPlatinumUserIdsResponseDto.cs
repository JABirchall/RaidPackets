
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena.Dtos
{
	[MessagePackObject]
	public class GetPlatinumUserIdsResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<long> UserIds;
		[Json]
		// [Key]
		public long? PlatinumLeagueFloorValue;
	
		// Constructors
		public GetPlatinumUserIdsResponseDto() {}
	}
}
