
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.CommonDtos;
using SharedModel.Meta.Battle.Arena;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class Arena3X3ResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public bool IsRecalculating;
		[Json]
		// [Key]
		public LongRange Borders;
		[Json]
		// [Key]
		public long? RatingStatusId;
		[Json]
		// [Key]
		public ArenaLeagueId? LeagueId;
		[Json]
		// [Key]
		public DateTime? LastRecalculateTime;
	
		// Constructors
		public Arena3X3ResponseDto() {}
	}
}
