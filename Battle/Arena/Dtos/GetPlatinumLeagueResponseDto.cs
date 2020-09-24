
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using Plarium.GS.Model.Modules.GlobalRatings.Entities;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Notes;



namespace SharedModel.Meta.Battle.Arena.Dtos
{
	[MessagePackObject]
	public class GetPlatinumLeagueResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<GlobalRatingItem> Items;
		[Json]
		// [Key]
		public List<UserNote> UserNotes;
		[Json]
		// [Key]
		public List<ShortUserNote> ShortUserNotes;
		[Json]
		// [Key]
		public ArenaLeagueId ArenaLeagueId;
		[Json]
		// [Key]
		public long? PlatinumLeagueFloorValue;
	
		// Constructors
		public GetPlatinumLeagueResponseDto() {}
	}
}
