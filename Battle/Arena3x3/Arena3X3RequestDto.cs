
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Battle.Arena;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class Arena3X3RequestDto
	{
		// Fields
		[Json]
		// [Key]
		public ArenaLeagueId KnownLeagueId;
		[Json]
		// [Key]
		public long KnownRatingStatusId;
	
		// Constructors
		public Arena3X3RequestDto() {}
	}
}
