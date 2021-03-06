﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using Plarium.Common.Serialization.Json2.Readers;
using Plarium.GS.Model.Modules.GlobalRatings.Entities;
using SharedModel.Meta.Notes;



namespace SharedModel.Meta.Tournaments.Dtos
{
	[MessagePackObject]
	public class GetTournamentGlobalInfoResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<GlobalRatingItem> NoviceItems;
		[Json]
		// [Key]
		public List<GlobalRatingItem> OldItems;
		[Json]
		// [Key]
		public List<GlobalRatingItem> GlobalItems;
		[Json]
		// [Key]
		public List<UserNote> UserNotes;
		[Json]
		// [Key]
		public int QuestId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public JsonValue RawJson { get; set; }
	
		// Constructors
		public GetTournamentGlobalInfoResponseDto() {}
	}
}
